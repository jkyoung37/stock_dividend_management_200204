namespace stock_div.Models
{
    using Npgsql;
    using stock_div.Models.DTO;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;

    public class StockDbContext : DbContext
    {
        #region 接続プロパティ
        public DbSet<Users> Users { get; set; }

        public DbSet<Stocks> Stocks { get; set; }

        public DbSet<Dividend> Dividend { get; set; }
        /// <summary>
        /// 参照するスキーマ。
        /// </summary>
        public string DefaultSchema { get; private set; }
        #endregion

        #region イベント
        /// <summary>
        /// スキーマを変更したい場合はここで変更。
        /// 指定が無いとスキーマ名は『dbo』に設定される。
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region コンストラクタ。
        /// <summary>
        /// コンストラクタ。
        /// </summary>
        public StockDbContext() : base(nameOrConnectionString: "Default") { }
        #endregion
    }
}