using XpertStudio.Common.Data;
using XpertStudio.Common.Managers;

namespace BlazorPWA.Shared.Managers
{
    public interface IGenericManager<T> : IManager where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync(PagedRequest request);
        public Task<T> GetDataAsync(string ID);
        public Task<T> SaveAsync(T entity);
        public Task<T> EditAsync(T entity);
        public Task<bool> DeleteAsync(string id);
        public Task<int> GetCount(string? WhereExpression = null);
        public Task<IEnumerable<FinderData>> GetFinder(string? FinderName = null, string? WhereExpression = null);
        public Task<T> GetDefault();
        public Task<IResult<byte[]>> ExportToExcelAsync(string searchString = "");
    }
}