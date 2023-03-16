namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Headings", name: "Writer_Id", newName: "WriterId");
            RenameIndex(table: "dbo.Headings", name: "IX_Writer_Id", newName: "IX_WriterId");
            AlterColumn("dbo.Abouts", "AboutDetails1", c => c.String(maxLength: 500));
            AlterColumn("dbo.Abouts", "AboutDetails2", c => c.String(maxLength: 500));
            AlterColumn("dbo.Abouts", "AboutImage1", c => c.String(maxLength: 100));
            AlterColumn("dbo.Abouts", "AboutImage2", c => c.String(maxLength: 100));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.Headings", "HeadingName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contents", "ContentValue", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "WriterName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "WriterLastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "WriterImage", c => c.String(maxLength: 100));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "UserMail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "Subject", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Contacts", "Message", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Message", c => c.String());
            AlterColumn("dbo.Contacts", "Subject", c => c.String());
            AlterColumn("dbo.Contacts", "UserMail", c => c.String());
            AlterColumn("dbo.Contacts", "UserName", c => c.String());
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String());
            AlterColumn("dbo.Writers", "WriterMail", c => c.String());
            AlterColumn("dbo.Writers", "WriterImage", c => c.String());
            AlterColumn("dbo.Writers", "WriterLastName", c => c.String());
            AlterColumn("dbo.Writers", "WriterName", c => c.String());
            AlterColumn("dbo.Contents", "ContentValue", c => c.String());
            AlterColumn("dbo.Headings", "HeadingName", c => c.String());
            AlterColumn("dbo.Categories", "CategoryDescription", c => c.String());
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            AlterColumn("dbo.Abouts", "AboutImage2", c => c.String());
            AlterColumn("dbo.Abouts", "AboutImage1", c => c.String());
            AlterColumn("dbo.Abouts", "AboutDetails2", c => c.String());
            AlterColumn("dbo.Abouts", "AboutDetails1", c => c.String());
            RenameIndex(table: "dbo.Headings", name: "IX_WriterId", newName: "IX_Writer_Id");
            RenameColumn(table: "dbo.Headings", name: "WriterId", newName: "Writer_Id");
        }
    }
}
