namespace saledev.Result
{
    public class PagedInfo
    {

        public PagedInfo(long pageNumber, long pageSize, long totalRecords)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalPages = (totalRecords - 1) / PageSize + 1;
            TotalRecords = totalRecords;
        }

        public long PageNumber { get; private set; }
        public long PageSize { get; private set; }
        public long TotalPages { get; private set; }
        public long TotalRecords { get; private set; }
    }
}
