using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHT.CRM.DAL
{
    /// <summary>
    /// 封装DbContext，实现IDisposable接口，以实现自动释放DbContext的目的
    /// </summary>
    /// <typeparam name="TDbContext"></typeparam>
    public class LHTCRMBaseRespository<TDbContext>:IDisposable
        where TDbContext:DbContext
    {
        protected TDbContext _dbContext = null;

        public LHTCRMBaseRespository(TDbContext context)
        {
            _dbContext = context;
        }

        #region "基类Respository需要调用的功能"
        public int SaveChanges()
        {
            if (_dbContext != null)
            {
                return _dbContext.SaveChanges();
            }
            return 0;
        }

        public Task<int> SaveChangesAsync()
        {
            if (_dbContext != null)
            {
                return _dbContext.SaveChangesAsync();
            }
            return Task.FromResult(0);
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
