namespace saledev.Result
{
    public class PagedResult<T> : Result<T>
    {
        public PagedResult(PagedInfo pagedInfo, T value) : base(value)
        {
            PagedInfo = pagedInfo;
        }

        public PagedInfo PagedInfo { get; }

        public override PagedInfo GetPagedInfo()
        {
            return PagedInfo;
        }
    }
}
