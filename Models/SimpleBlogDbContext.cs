using Microsoft.EntityFrameworkCore;

namespace SimpleBlog.Models;

public class SimpleBlogDbContext : DbContext
{
	public SimpleBlogDbContext(DbContextOptions<SimpleBlogDbContext> options) : base(options){}
}
