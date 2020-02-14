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
        #region �ڑ��v���p�e�B
        public DbSet<Users> Users { get; set; }

        public DbSet<Stocks> Stocks { get; set; }

        public DbSet<Dividend> Dividend { get; set; }
        /// <summary>
        /// �Q�Ƃ���X�L�[�}�B
        /// </summary>
        public string DefaultSchema { get; private set; }
        #endregion

        #region �C�x���g
        /// <summary>
        /// �X�L�[�}��ύX�������ꍇ�͂����ŕύX�B
        /// �w�肪�����ƃX�L�[�}���́wdbo�x�ɐݒ肳���B
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region �R���X�g���N�^�B
        /// <summary>
        /// �R���X�g���N�^�B
        /// </summary>
        public StockDbContext() : base(nameOrConnectionString: "Default") { }
        #endregion
    }
}