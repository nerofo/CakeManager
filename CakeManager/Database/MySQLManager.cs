using CakeManager.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
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
            await Task.Factory.StartNew(() =>
            {
                this.Entry<TEntity>(item).State = EntityState.Modified;
            });
            await this.SaveChangesAsync();
            return item;
        }

        public async Task<IEnumerable<TEntity>> Update(IEnumerable<TEntity> items)
        {
            foreach (var item in items)
            {
                this.Entry<TEntity>(item).State = EntityState.Modified;
            }
            await this.SaveChangesAsync();
            return items;
        }

        public async Task<TEntity> Get(Int32 id)
        {
            return await this.DbSetT.FindAsync(id) as TEntity;
        }

        public List<TEntity> GetListByWhere(String table, String column, Int32 value)
        {
            List<TEntity> items = this.DbSetT.SqlQuery("SELECT * FROM " + table + " WHERE " + column + " = " + value).ToList<TEntity>();
            return items;
        }

        public TEntity GetByWhere(String table, String column, Int32 value)
        {
            List<TEntity> items = this.DbSetT.SqlQuery("SELECT * FROM " + table + " WHERE " + column + " = " + value).ToList<TEntity>();
            if (items != null && items.Count > 0)
                return items[0];
            else
                return null;
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
