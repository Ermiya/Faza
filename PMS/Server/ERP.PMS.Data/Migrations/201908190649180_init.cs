namespace ERP.PMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HRJBSKRT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        srl = c.Int(nullable: false),
                        name = c.String(),
                        family = c.String(),
                        birth_date = c.DateTime(nullable: false),
                        phone_number = c.String(),
                        mobile_number = c.String(),
                        status = c.Short(nullable: false),
                        des = c.String(),
                        reagent_name = c.String(),
                        avg_limit = c.Short(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HRSLRDLT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        hrsalry_srl = c.Int(nullable: false),
                        accsisn_srl = c.Int(nullable: false),
                        srl = c.Int(nullable: false),
                        amount = c.Long(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HRSALRYT", t => t.hrsalry_srl, cascadeDelete: true)
                .Index(t => t.hrsalry_srl);
            
            CreateTable(
                "dbo.HRSALRYT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        hrcntrc_srl = c.Int(nullable: false),
                        srl = c.Int(nullable: false),
                        chdprmn_srl = c.Int(nullable: false),
                        chdprmn_srl_assign = c.Int(nullable: false),
                        hrjobst_srl = c.Int(nullable: false),
                        chpostn_srl = c.Int(nullable: false),
                        job_group = c.Short(nullable: false),
                        job_rank = c.Short(nullable: false),
                        status = c.Byte(nullable: false),
                        apply_date = c.DateTime(),
                        cancel_date = c.DateTime(),
                        run_date = c.DateTime(nullable: false),
                        hrslrds_srl = c.Short(nullable: false),
                        salary_type = c.Short(nullable: false),
                        insurance_type = c.Short(nullable: false),
                        uausrid_srl_apply = c.Int(),
                        uausrid_srl_cancel = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                        SalaryDescription_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HRJOBSTT", t => t.hrjobst_srl, cascadeDelete: true)
                .ForeignKey("dbo.HRCNTRCT", t => t.hrcntrc_srl, cascadeDelete: true)
                .ForeignKey("dbo.HRSLRDST", t => t.SalaryDescription_Id)
                .Index(t => t.hrcntrc_srl)
                .Index(t => t.hrjobst_srl)
                .Index(t => t.SalaryDescription_Id);
            
            CreateTable(
                "dbo.HRCNTRCT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        hrprsnl_srl = c.Int(nullable: false),
                        srl = c.Int(nullable: false),
                        start_date = c.Int(nullable: false),
                        end_date = c.Int(nullable: false),
                        ceil_operat_time = c.Int(nullable: false),
                        employ_type = c.Byte(nullable: false),
                        contract_type = c.Int(nullable: false),
                        status = c.Byte(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HRPRSNLT", t => t.hrprsnl_srl, cascadeDelete: true)
                .Index(t => t.hrprsnl_srl);
            
            CreateTable(
                "dbo.HRPRSNLT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        family = c.String(),
                        status = c.Short(nullable: false),
                        hrjbskr_srl = c.Int(),
                        l_name = c.String(),
                        l_family = c.String(),
                        id_no = c.String(),
                        birth_date = c.DateTime(nullable: false),
                        sex = c.Byte(nullable: false),
                        pucitys_srl_issuance = c.Int(),
                        pucitys_srl = c.Int(nullable: false),
                        marriage_date = c.DateTime(),
                        address = c.String(),
                        phone_number = c.String(),
                        mobile_number = c.String(),
                        injuries_prcnt = c.Decimal(precision: 18, scale: 2),
                        housing_type = c.Int(),
                        summa = c.Int(),
                        blood_type = c.Int(),
                        marital_status = c.Int(nullable: false),
                        religion_type = c.Int(),
                        soldier_type = c.Int(),
                        martyr = c.Boolean(),
                        shahed = c.Boolean(nullable: false),
                        front_duration = c.Short(),
                        bondage_duration = c.Short(),
                        front_continuous = c.Byte(),
                        postal_code = c.String(),
                        meli_code = c.String(),
                        id_serial_no = c.String(),
                        picture = c.Binary(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HRJOBSTT", t => t.hrjbskr_srl)
                .Index(t => t.hrjbskr_srl);
            
            CreateTable(
                "dbo.HRDPNDNT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        hrprsnl_srl = c.Int(nullable: false),
                        nam = c.String(),
                        family = c.String(),
                        validity_date = c.DateTime(),
                        sex = c.Byte(nullable: false),
                        relation = c.Int(nullable: false),
                        birth_date = c.DateTime(),
                        marriage_date = c.DateTime(),
                        id_no = c.String(),
                        education_type = c.Int(nullable: false),
                        pucitys_srl = c.Int(nullable: false),
                        under_shelter = c.Boolean(nullable: false),
                        splmntry_insurance = c.Boolean(nullable: false),
                        meli_code = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HRPRSNLT", t => t.hrprsnl_srl, cascadeDelete: true)
                .Index(t => t.hrprsnl_srl);
            
            CreateTable(
                "dbo.HRJOBSTT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        srl = c.Int(nullable: false),
                        job_code = c.String(),
                        title = c.String(),
                        job_type = c.Short(nullable: false),
                        supervisor = c.Boolean(nullable: false),
                        status = c.Byte(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HREDUSTT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        hrprsnl_srl = c.Int(nullable: false),
                        start_date = c.DateTime(),
                        end_date = c.DateTime(),
                        education_type = c.Int(nullable: false),
                        university_name = c.String(),
                        field_name = c.String(),
                        trend_name = c.String(),
                        averag = c.Decimal(precision: 18, scale: 2),
                        status = c.Byte(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HRPRSNLT", t => t.hrprsnl_srl, cascadeDelete: true)
                .Index(t => t.hrprsnl_srl);
            
            CreateTable(
                "dbo.HRTIMEMT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        srl = c.Int(nullable: false),
                        yer = c.Short(nullable: false),
                        mon = c.Short(nullable: false),
                        hrprsnl_srl = c.Int(nullable: false),
                        modify_yer = c.Short(nullable: false),
                        modify_mon = c.Short(nullable: false),
                        status = c.Short(nullable: false),
                        time_type = c.Short(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HRPRSNLT", t => t.hrprsnl_srl, cascadeDelete: true)
                .Index(t => t.hrprsnl_srl);
            
            CreateTable(
                "dbo.HRSLRDST",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        srl = c.Short(nullable: false),
                        des = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HRTIMEDT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        hrtimem_srl = c.Int(nullable: false),
                        time_title_code = c.Short(nullable: false),
                        hour_time = c.Int(nullable: false),
                        minute_time = c.Short(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HRWRKXPT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        hrprsnl_srl = c.Int(nullable: false),
                        start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                        job_title = c.String(),
                        job_place = c.String(),
                        duration = c.Short(nullable: false),
                        duration_confirm = c.Short(),
                        des = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        DeleterUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HRPRSNLT", t => t.hrprsnl_srl, cascadeDelete: true)
                .Index(t => t.hrprsnl_srl);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HRWRKXPT", "hrprsnl_srl", "dbo.HRPRSNLT");
            DropForeignKey("dbo.HRSLRDLT", "hrsalry_srl", "dbo.HRSALRYT");
            DropForeignKey("dbo.HRSALRYT", "SalaryDescription_Id", "dbo.HRSLRDST");
            DropForeignKey("dbo.HRSALRYT", "hrcntrc_srl", "dbo.HRCNTRCT");
            DropForeignKey("dbo.HRTIMEMT", "hrprsnl_srl", "dbo.HRPRSNLT");
            DropForeignKey("dbo.HREDUSTT", "hrprsnl_srl", "dbo.HRPRSNLT");
            DropForeignKey("dbo.HRSALRYT", "hrjobst_srl", "dbo.HRJOBSTT");
            DropForeignKey("dbo.HRPRSNLT", "hrjbskr_srl", "dbo.HRJOBSTT");
            DropForeignKey("dbo.HRDPNDNT", "hrprsnl_srl", "dbo.HRPRSNLT");
            DropForeignKey("dbo.HRCNTRCT", "hrprsnl_srl", "dbo.HRPRSNLT");
            DropIndex("dbo.HRWRKXPT", new[] { "hrprsnl_srl" });
            DropIndex("dbo.HRTIMEMT", new[] { "hrprsnl_srl" });
            DropIndex("dbo.HREDUSTT", new[] { "hrprsnl_srl" });
            DropIndex("dbo.HRDPNDNT", new[] { "hrprsnl_srl" });
            DropIndex("dbo.HRPRSNLT", new[] { "hrjbskr_srl" });
            DropIndex("dbo.HRCNTRCT", new[] { "hrprsnl_srl" });
            DropIndex("dbo.HRSALRYT", new[] { "SalaryDescription_Id" });
            DropIndex("dbo.HRSALRYT", new[] { "hrjobst_srl" });
            DropIndex("dbo.HRSALRYT", new[] { "hrcntrc_srl" });
            DropIndex("dbo.HRSLRDLT", new[] { "hrsalry_srl" });
            DropTable("dbo.HRWRKXPT");
            DropTable("dbo.HRTIMEDT");
            DropTable("dbo.HRSLRDST");
            DropTable("dbo.HRTIMEMT");
            DropTable("dbo.HREDUSTT");
            DropTable("dbo.HRJOBSTT");
            DropTable("dbo.HRDPNDNT");
            DropTable("dbo.HRPRSNLT");
            DropTable("dbo.HRCNTRCT");
            DropTable("dbo.HRSALRYT");
            DropTable("dbo.HRSLRDLT");
            DropTable("dbo.HRJBSKRT");
        }
    }
}
