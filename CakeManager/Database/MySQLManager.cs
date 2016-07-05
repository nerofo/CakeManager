﻿using CakeManager.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeManager.Database
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MySQLManager<TEntity> : DbContext where TEntity :class
    {
        public DbSet<TEntity> DbSetT { get; set; }

        public MySQLManager(DataConnectionResource dataConnectionResource)
                    : base(EnumString.GetStringValue(dataConnectionResource))
        {
            FullDb full = new FullDb(dataConnectionResource);
        }

        public async Task<TEntity> Insert(TEntity item)
        {
            this.DbSetT.Add(item);
            await this.SaveChangesAsync();
            return item;
        }

        public async Task<IEnumerable<TEntity>> Insert(IEnumerable<TEntity> items)
        {
            foreach (var item in items)
            {
                this.DbSetT.Add(item);
            }
            await this.SaveChangesAsync();
            return items;
        }

        public async Task<TEntity> Update(TEntity item)
        {
            this.Entry<TEntity>(item);
            await this.SaveChangesAsync();
            return item;
        }

        public async Task<IEnumerable<TEntity>> Update(IEnumerable<TEntity> items)
        {
            foreach (var item in items)
            {
                this.Entry<TEntity>(item);
            }
            await this.SaveChangesAsync();
            return items;
        }

        public async Task<TEntity> Get(Int32 id)
        {
            return await this.DbSetT.FindAsync(id) as TEntity;
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            DbSet<TEntity> temp = default(DbSet<TEntity>);
            List<TEntity> result = new List<TEntity>();
            await Task.Factory.StartNew(() =>
            {
                temp = base.Set<TEntity>();
            });
            result.AddRange(temp);
            return result;
        }

        public async Task<Int32> Delete(TEntity item)
        {
            await Task.Factory.StartNew(() =>
            {
                this.DbSetT.Attach(item);
                this.DbSetT.Remove(item);
            });
            return await this.SaveChangesAsync();
        }

        public async Task<Int32> Delete(IEnumerable<TEntity> items)
        {
            await Task.Factory.StartNew(() =>
            {
                this.DbSetT.Attach((items as List<TEntity>)[0]);
                this.DbSetT.RemoveRange(items);
            });
            var res = await this.SaveChangesAsync();
            return res;
        }
    }
}
