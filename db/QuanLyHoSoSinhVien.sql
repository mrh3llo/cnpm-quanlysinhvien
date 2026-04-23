/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     23/04/2026 23:47:47                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOP') and o.name = 'FK_LOP_QUANLY_LO_KHOA_TRU')
alter table LOP
   drop constraint FK_LOP_QUANLY_LO_KHOA_TRU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NGANH') and o.name = 'FK_NGANH_QUANLY_NG_KHOA_TRU')
alter table NGANH
   drop constraint FK_NGANH_QUANLY_NG_KHOA_TRU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NGANH') and o.name = 'FK_NGANH_THUOCKHOA_KHOA_TRU')
alter table NGANH
   drop constraint FK_NGANH_THUOCKHOA_KHOA_TRU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SINHVIEN') and o.name = 'FK_SINHVIEN_LA_DANTOC_DANTOC')
alter table SINHVIEN
   drop constraint FK_SINHVIEN_LA_DANTOC_DANTOC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SINHVIEN') and o.name = 'FK_SINHVIEN_QUEQUAN_T_TINHTHAN')
alter table SINHVIEN
   drop constraint FK_SINHVIEN_QUEQUAN_T_TINHTHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SINHVIEN') and o.name = 'FK_SINHVIEN_QUEQUAN_T_XAPHUONG')
alter table SINHVIEN
   drop constraint FK_SINHVIEN_QUEQUAN_T_XAPHUONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SINHVIEN') and o.name = 'FK_SINHVIEN_SINHTAI_T_TINHTHAN')
alter table SINHVIEN
   drop constraint FK_SINHVIEN_SINHTAI_T_TINHTHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SINHVIEN') and o.name = 'FK_SINHVIEN_THEO_TONG_TONGIAO')
alter table SINHVIEN
   drop constraint FK_SINHVIEN_THEO_TONG_TONGIAO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SINHVIEN') and o.name = 'FK_SINHVIEN_THUOC_KHO_KHOA_TRU')
alter table SINHVIEN
   drop constraint FK_SINHVIEN_THUOC_KHO_KHOA_TRU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('XAPHUONG') and o.name = 'FK_XAPHUONG_TRUCTHUOC_TINHTHAN')
alter table XAPHUONG
   drop constraint FK_XAPHUONG_TRUCTHUOC_TINHTHAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DANTOC')
            and   type = 'U')
   drop table DANTOC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHOA_TRUONG')
            and   type = 'U')
   drop table KHOA_TRUONG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOP')
            and   name  = 'QUANLY_LOP_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOP.QUANLY_LOP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOP')
            and   type = 'U')
   drop table LOP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NGANH')
            and   name  = 'QUANLY_NGANH_FK'
            and   indid > 0
            and   indid < 255)
   drop index NGANH.QUANLY_NGANH_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NGANH')
            and   type = 'U')
   drop table NGANH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINHVIEN')
            and   name  = 'QUEQUAN_TAI_TT_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINHVIEN.QUEQUAN_TAI_TT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINHVIEN')
            and   name  = 'QUEQUAN_TAI_XP_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINHVIEN.QUEQUAN_TAI_XP_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINHVIEN')
            and   name  = 'THUOC_KHOA_TRUONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINHVIEN.THUOC_KHOA_TRUONG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINHVIEN')
            and   name  = 'SINHTAI_TINHTHANH_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINHVIEN.SINHTAI_TINHTHANH_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINHVIEN')
            and   name  = 'THEO_TONGIAO_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINHVIEN.THEO_TONGIAO_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINHVIEN')
            and   name  = 'LA_DANTOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINHVIEN.LA_DANTOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SINHVIEN')
            and   type = 'U')
   drop table SINHVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TINHTHANH')
            and   type = 'U')
   drop table TINHTHANH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TONGIAO')
            and   type = 'U')
   drop table TONGIAO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('XAPHUONG')
            and   name  = 'TRUCTHUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index XAPHUONG.TRUCTHUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('XAPHUONG')
            and   type = 'U')
   drop table XAPHUONG
go

/*==============================================================*/
/* Table: DANTOC                                                */
/*==============================================================*/
create table DANTOC (
   MADANTOC             char(5)              not null,
   TENDANTOC            varchar(30)          null,
   constraint PK_DANTOC primary key (MADANTOC)
)
go

/*==============================================================*/
/* Table: KHOA_TRUONG                                           */
/*==============================================================*/
create table KHOA_TRUONG (
   MAKHOATRUONG         char(5)              not null,
   TENKHOATRUONG        varchar(30)          null,
   constraint PK_KHOA_TRUONG primary key (MAKHOATRUONG)
)
go

/*==============================================================*/
/* Table: LOP                                                   */
/*==============================================================*/
create table LOP (
   MALOP                char(5)              not null,
   MAKHOATRUONG         char(5)              null,
   TENLOP               varchar(30)          null,
   constraint PK_LOP primary key (MALOP)
)
go

/*==============================================================*/
/* Index: QUANLY_LOP_FK                                         */
/*==============================================================*/




create nonclustered index QUANLY_LOP_FK on LOP (MAKHOATRUONG ASC)
go

/*==============================================================*/
/* Table: NGANH                                                 */
/*==============================================================*/
create table NGANH (
   MANGHANH             char(5)              not null,
   MAKHOATRUONG         char(5)              null,
   TENNGANH             varchar(30)          null,
   constraint PK_NGANH primary key (MANGHANH)
)
go

/*==============================================================*/
/* Index: QUANLY_NGANH_FK                                       */
/*==============================================================*/




create nonclustered index QUANLY_NGANH_FK on NGANH (MAKHOATRUONG ASC)
go

/*==============================================================*/
/* Table: SINHVIEN                                              */
/*==============================================================*/
create table SINHVIEN (
   MASV                 char(10)             not null,
   MATINHTHANH          char(5)              not null,
   MAXAPHUONG           char(5)              not null,
   MATONGIAO            char(5)              null,
   MAKHOATRUONG         char(5)              not null,
   MADANTOC             char(5)              not null,
   TIN_MATINHTHANH      char(5)              not null,
   HO                   varchar(20)          null,
   TENLOT               varchar(40)          null,
   TEN                  varchar(20)          null,
   MATKHAUTK            text                 null,
   EMAIL                text                 null,
   SDT                  char(10)             null,
   GIOITINH             bit                  null,
   NGAYSINH             datetime             null,
   SOCCCD               char(12)             null,
   DIACHITHUONGTRU      varchar(100)         null,
   NIENKHOA             char(10)             null,
   TRANGTHAI            int                  null,
   constraint PK_SINHVIEN primary key (MASV)
)
go

/*==============================================================*/
/* Index: LA_DANTOC_FK                                          */
/*==============================================================*/




create nonclustered index LA_DANTOC_FK on SINHVIEN (MADANTOC ASC)
go

/*==============================================================*/
/* Index: THEO_TONGIAO_FK                                       */
/*==============================================================*/




create nonclustered index THEO_TONGIAO_FK on SINHVIEN (MATONGIAO ASC)
go

/*==============================================================*/
/* Index: SINHTAI_TINHTHANH_FK                                  */
/*==============================================================*/




create nonclustered index SINHTAI_TINHTHANH_FK on SINHVIEN (TIN_MATINHTHANH ASC)
go

/*==============================================================*/
/* Index: THUOC_KHOA_TRUONG_FK                                  */
/*==============================================================*/




create nonclustered index THUOC_KHOA_TRUONG_FK on SINHVIEN (MAKHOATRUONG ASC)
go

/*==============================================================*/
/* Index: QUEQUAN_TAI_XP_FK                                     */
/*==============================================================*/




create nonclustered index QUEQUAN_TAI_XP_FK on SINHVIEN (MAXAPHUONG ASC)
go

/*==============================================================*/
/* Index: QUEQUAN_TAI_TT_FK                                     */
/*==============================================================*/




create nonclustered index QUEQUAN_TAI_TT_FK on SINHVIEN (MATINHTHANH ASC)
go

/*==============================================================*/
/* Table: TINHTHANH                                             */
/*==============================================================*/
create table TINHTHANH (
   MATINHTHANH          char(5)              not null,
   TENTINHTHANH         varchar(30)          null,
   constraint PK_TINHTHANH primary key (MATINHTHANH)
)
go

/*==============================================================*/
/* Table: TONGIAO                                               */
/*==============================================================*/
create table TONGIAO (
   MATONGIAO            char(5)              not null,
   TENTONGIAO           varchar(30)          null,
   constraint PK_TONGIAO primary key (MATONGIAO)
)
go

/*==============================================================*/
/* Table: XAPHUONG                                              */
/*==============================================================*/
create table XAPHUONG (
   MAXAPHUONG           char(5)              not null,
   MATINHTHANH          char(5)              not null,
   TENXAPHUONG          varchar(30)          null,
   constraint PK_XAPHUONG primary key (MAXAPHUONG)
)
go

/*==============================================================*/
/* Index: TRUCTHUOC_FK                                          */
/*==============================================================*/




create nonclustered index TRUCTHUOC_FK on XAPHUONG (MATINHTHANH ASC)
go

alter table LOP
   add constraint FK_LOP_QUANLY_LO_KHOA_TRU foreign key (MAKHOATRUONG)
      references KHOA_TRUONG (MAKHOATRUONG)
go

alter table NGANH
   add constraint FK_NGANH_QUANLY_NG_KHOA_TRU foreign key (MAKHOATRUONG)
      references KHOA_TRUONG (MAKHOATRUONG)
go

alter table NGANH
   add constraint FK_NGANH_THUOCKHOA_KHOA_TRU foreign key (MAKHOATRUONG)
      references KHOA_TRUONG (MAKHOATRUONG)
go

alter table SINHVIEN
   add constraint FK_SINHVIEN_LA_DANTOC_DANTOC foreign key (MADANTOC)
      references DANTOC (MADANTOC)
go

alter table SINHVIEN
   add constraint FK_SINHVIEN_QUEQUAN_T_TINHTHAN foreign key (MATINHTHANH)
      references TINHTHANH (MATINHTHANH)
go

alter table SINHVIEN
   add constraint FK_SINHVIEN_QUEQUAN_T_XAPHUONG foreign key (MAXAPHUONG)
      references XAPHUONG (MAXAPHUONG)
go

alter table SINHVIEN
   add constraint FK_SINHVIEN_SINHTAI_T_TINHTHAN foreign key (TIN_MATINHTHANH)
      references TINHTHANH (MATINHTHANH)
go

alter table SINHVIEN
   add constraint FK_SINHVIEN_THEO_TONG_TONGIAO foreign key (MATONGIAO)
      references TONGIAO (MATONGIAO)
go

alter table SINHVIEN
   add constraint FK_SINHVIEN_THUOC_KHO_KHOA_TRU foreign key (MAKHOATRUONG)
      references KHOA_TRUONG (MAKHOATRUONG)
go

alter table XAPHUONG
   add constraint FK_XAPHUONG_TRUCTHUOC_TINHTHAN foreign key (MATINHTHANH)
      references TINHTHANH (MATINHTHANH)
go

