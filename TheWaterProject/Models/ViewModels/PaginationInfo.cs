namespace TheWaterProject.Models.ViewModels
    // This is the pagination file which holds our key variables for the page count.
{
    public class PaginationInfo
    {
        public int TotalItems {  get; set; }
        public int ItemsPerPage { get; set; }
        public int Currentpage { get; set; }
        public int TotalNumPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
