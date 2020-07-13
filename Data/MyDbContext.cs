using Microsoft.EntityFrameworkCore;

/// <summary>
/// DBコンテキスト
/// </summary>
public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    /// <summary>
    /// ユーザ情報
    /// </summary>
    public DbSet<UserInfo> UserInfoes { get; set; }

    /// <summary>
    /// 組織情報
    /// </summary>
    public DbSet<Organization> Organizations { get; set; }
}
