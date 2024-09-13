namespace JsvBlog.Business.ViewModels
{
    public class PostViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Excerpt { get; set; } = string.Empty;
        public bool IsPublished { get; set; } = false;
        public DateTime CreateDate { get; set; }
        public DateTime PubDate { get; set; }
        public DateTime LastModified { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string UrlContent { get; set; } = string.Empty;

        public IEnumerable<CategoryViewModel> Categories { get; set; }
        public IEnumerable<TagViewModel> Tags { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}
