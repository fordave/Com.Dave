namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BaseBillPush> BaseBillPushes { get; set; }
        public virtual DbSet<BaseComment> BaseComments { get; set; }
        public virtual DbSet<BaseContact> BaseContacts { get; set; }
        public virtual DbSet<BaseContactDetail> BaseContactDetails { get; set; }
        public virtual DbSet<BaseException> BaseExceptions { get; set; }
        public virtual DbSet<BaseExportData> BaseExportDatas { get; set; }
        public virtual DbSet<BaseFile> BaseFiles { get; set; }
        public virtual DbSet<BaseFolder> BaseFolders { get; set; }
        public virtual DbSet<BaseHoliday> BaseHolidays { get; set; }
        public virtual DbSet<BaseItemDetail> BaseItemDetails { get; set; }
        public virtual DbSet<BaseItem> BaseItems { get; set; }
        public virtual DbSet<BaseKnowledge> BaseKnowledges { get; set; }
        public virtual DbSet<BaseLog> BaseLogs { get; set; }
        public virtual DbSet<BaseLoginLog> BaseLoginLogs { get; set; }
        public virtual DbSet<BaseMessage> BaseMessages { get; set; }
        public virtual DbSet<BaseMessageRecent> BaseMessageRecents { get; set; }
        public virtual DbSet<BaseModifyRecord> BaseModifyRecords { get; set; }
        public virtual DbSet<BaseModule> BaseModules { get; set; }
        public virtual DbSet<BaseModule_old> BaseModule_old { get; set; }
        public virtual DbSet<BaseNew> BaseNews { get; set; }
        public virtual DbSet<BaseOrganize> BaseOrganizes { get; set; }
        public virtual DbSet<BaseOrganizeScope> BaseOrganizeScopes { get; set; }
        public virtual DbSet<BaseParameter> BaseParameters { get; set; }
        public virtual DbSet<BasePermission> BasePermissions { get; set; }
        public virtual DbSet<BasePermissionScope> BasePermissionScopes { get; set; }
        public virtual DbSet<BaseRole> BaseRoles { get; set; }
        public virtual DbSet<BaseRoleDeleted> BaseRoleDeleteds { get; set; }
        public virtual DbSet<BaseRoleOrganize> BaseRoleOrganizes { get; set; }
        public virtual DbSet<BaseSequence> BaseSequences { get; set; }
        public virtual DbSet<BaseStaff> BaseStaffs { get; set; }
        public virtual DbSet<BaseStaffOrganize> BaseStaffOrganizes { get; set; }
        public virtual DbSet<BaseTableColumn> BaseTableColumns { get; set; }
        public virtual DbSet<BaseUser> BaseUsers { get; set; }
        public virtual DbSet<BaseUserAddress> BaseUserAddresses { get; set; }
        public virtual DbSet<BaseUserContact> BaseUserContacts { get; set; }
        public virtual DbSet<BaseUserLogOn> BaseUserLogOns { get; set; }
        public virtual DbSet<BaseUserOrganize> BaseUserOrganizes { get; set; }
        public virtual DbSet<BaseUserRole> BaseUserRoles { get; set; }
        public virtual DbSet<BaseUserScore> BaseUserScores { get; set; }
        public virtual DbSet<BusinessCard> BusinessCards { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<FriendFan> FriendFans { get; set; }
        public virtual DbSet<FriendItem> FriendItems { get; set; }
        public virtual DbSet<FriendModule> FriendModules { get; set; }
        public virtual DbSet<FriendPermission> FriendPermissions { get; set; }
        public virtual DbSet<FriendPermissionScope> FriendPermissionScopes { get; set; }
        public virtual DbSet<FriendRole> FriendRoles { get; set; }
        public virtual DbSet<FriendSupport> FriendSupports { get; set; }
        public virtual DbSet<FriendUserRole> FriendUserRoles { get; set; }
        public virtual DbSet<HeadhuntingItem> HeadhuntingItems { get; set; }
        public virtual DbSet<HeadhuntingModule> HeadhuntingModules { get; set; }
        public virtual DbSet<HeadhuntingOrganizeScope> HeadhuntingOrganizeScopes { get; set; }
        public virtual DbSet<HeadhuntingPermission> HeadhuntingPermissions { get; set; }
        public virtual DbSet<HeadhuntingPermissionScope> HeadhuntingPermissionScopes { get; set; }
        public virtual DbSet<HeadhuntingRole> HeadhuntingRoles { get; set; }
        public virtual DbSet<HeadhuntingUserRole> HeadhuntingUserRoles { get; set; }
        public virtual DbSet<ItemsAllowDelete> ItemsAllowDeletes { get; set; }
        public virtual DbSet<ItemsAllowEdit> ItemsAllowEdits { get; set; }
        public virtual DbSet<ItemsAuditIdea> ItemsAuditIdeas { get; set; }
        public virtual DbSet<ItemsAuditStatu> ItemsAuditStatus { get; set; }
        public virtual DbSet<ItemsBugCategory> ItemsBugCategories { get; set; }
        public virtual DbSet<ItemsBugLevel> ItemsBugLevels { get; set; }
        public virtual DbSet<ItemsCondition> ItemsConditions { get; set; }
        public virtual DbSet<ItemsDegree> ItemsDegrees { get; set; }
        public virtual DbSet<ItemsDeletionStateCode> ItemsDeletionStateCodes { get; set; }
        public virtual DbSet<ItemsDuty> ItemsDuties { get; set; }
        public virtual DbSet<ItemsEditField> ItemsEditFields { get; set; }
        public virtual DbSet<ItemsEducation> ItemsEducations { get; set; }
        public virtual DbSet<ItemsEnabled> ItemsEnableds { get; set; }
        public virtual DbSet<ItemsGender> ItemsGenders { get; set; }
        public virtual DbSet<ItemsIndustry> ItemsIndustries { get; set; }
        public virtual DbSet<ItemsLeaveCategory> ItemsLeaveCategories { get; set; }
        public virtual DbSet<ItemsLink> ItemsLinks { get; set; }
        public virtual DbSet<ItemsLockWaitMinute> ItemsLockWaitMinutes { get; set; }
        public virtual DbSet<ItemsMarriage> ItemsMarriages { get; set; }
        public virtual DbSet<ItemsNationality> ItemsNationalities { get; set; }
        public virtual DbSet<ItemsNewsCategory> ItemsNewsCategories { get; set; }
        public virtual DbSet<ItemsOrganizeCategory> ItemsOrganizeCategories { get; set; }
        public virtual DbSet<ItemsParty> ItemsParties { get; set; }
        public virtual DbSet<ItemsPriority> ItemsPriorities { get; set; }
        public virtual DbSet<ItemsRoleCategory> ItemsRoleCategories { get; set; }
        public virtual DbSet<ItemsSecurityLevel> ItemsSecurityLevels { get; set; }
        public virtual DbSet<ItemsSystem> ItemsSystems { get; set; }
        public virtual DbSet<ItemsTablePermissionScope> ItemsTablePermissionScopes { get; set; }
        public virtual DbSet<ItemsTitle> ItemsTitles { get; set; }
        public virtual DbSet<ItemsTrueFalse> ItemsTrueFalses { get; set; }
        public virtual DbSet<ItemsUnit> ItemsUnits { get; set; }
        public virtual DbSet<ItemsWorkCategory> ItemsWorkCategories { get; set; }
        public virtual DbSet<ItemsWorkFlowActivityCategory> ItemsWorkFlowActivityCategories { get; set; }
        public virtual DbSet<ItemsWorkFlowActivityName> ItemsWorkFlowActivityNames { get; set; }
        public virtual DbSet<ItemsWorkFlowCategory> ItemsWorkFlowCategories { get; set; }
        public virtual DbSet<ItemsWorkingProperty> ItemsWorkingProperties { get; set; }
        public virtual DbSet<ItemsWorkStatu> ItemsWorkStatus { get; set; }
        public virtual DbSet<ItemsYesNo> ItemsYesNoes { get; set; }
        public virtual DbSet<OptionItemsComputerCategory> OptionItemsComputerCategories { get; set; }
        public virtual DbSet<OptionItemsDisability> OptionItemsDisabilities { get; set; }
        public virtual DbSet<OptionItemsExpress> OptionItemsExpresses { get; set; }
        public virtual DbSet<OptionItemsFaPiaoShuXing> OptionItemsFaPiaoShuXings { get; set; }
        public virtual DbSet<OptionItemsFuKuanShuXing> OptionItemsFuKuanShuXings { get; set; }
        public virtual DbSet<OptionItemsHousehold> OptionItemsHouseholds { get; set; }
        public virtual DbSet<OptionItemsOilAlarmFiltering> OptionItemsOilAlarmFilterings { get; set; }
        public virtual DbSet<OptionItemsOilDataSource> OptionItemsOilDataSources { get; set; }
        public virtual DbSet<OptionItemsOilEventGroup> OptionItemsOilEventGroups { get; set; }
        public virtual DbSet<OptionItemsOilEventType> OptionItemsOilEventTypes { get; set; }
        public virtual DbSet<OptionItemsOilEventType_Old> OptionItemsOilEventType_Old { get; set; }
        public virtual DbSet<OptionItemsOilInstallation> OptionItemsOilInstallations { get; set; }
        public virtual DbSet<OptionItemsOnSale> OptionItemsOnSales { get; set; }
        public virtual DbSet<OptionItemsPayCategory> OptionItemsPayCategories { get; set; }
        public virtual DbSet<OptionItemsPostCategory> OptionItemsPostCategories { get; set; }
        public virtual DbSet<OptionItemsSalaryItemCategory> OptionItemsSalaryItemCategories { get; set; }
        public virtual DbSet<OptionItemsSendCategory> OptionItemsSendCategories { get; set; }
        public virtual DbSet<OptionItemsShouFeiLeiXing> OptionItemsShouFeiLeiXings { get; set; }
        public virtual DbSet<WorkFlowItem> WorkFlowItems { get; set; }
        public virtual DbSet<WorkFlowModule> WorkFlowModules { get; set; }
        public virtual DbSet<WorkFlowOrganizeScope> WorkFlowOrganizeScopes { get; set; }
        public virtual DbSet<WorkFlowPermission> WorkFlowPermissions { get; set; }
        public virtual DbSet<WorkFlowPermissionScope> WorkFlowPermissionScopes { get; set; }
        public virtual DbSet<WorkFlowRole> WorkFlowRoles { get; set; }
        public virtual DbSet<WorkFlowUserRole> WorkFlowUserRoles { get; set; }
        public virtual DbSet<YKGA_AJRYXX> YKGA_AJRYXX { get; set; }
        public virtual DbSet<YKGA_AJXX> YKGA_AJXX { get; set; }
        public virtual DbSet<YKGA_AreaBind> YKGA_AreaBind { get; set; }
        public virtual DbSet<YKGA_PersonRoomBind0> YKGA_PersonRoomBind0 { get; set; }
        public virtual DbSet<YKGA_VideoProcess> YKGA_VideoProcess { get; set; }
        public virtual DbSet<YKSACW_Device> YKSACW_Device { get; set; }
        public virtual DbSet<YKSAVR_BaseCity> YKSAVR_BaseCity { get; set; }
        public virtual DbSet<YKSAVR_BaseDistrict> YKSAVR_BaseDistrict { get; set; }
        public virtual DbSet<YKSAVR_BaseProvince> YKSAVR_BaseProvince { get; set; }
        public virtual DbSet<YKSAVR_Department> YKSAVR_Department { get; set; }
        public virtual DbSet<YKSAVR_Device> YKSAVR_Device { get; set; }
        public virtual DbSet<YKSAVR_DeviceChannel> YKSAVR_DeviceChannel { get; set; }
        public virtual DbSet<YKSAVR_DeviceType> YKSAVR_DeviceType { get; set; }
        public virtual DbSet<YKSAVR_DeviceTypeChannelIndexMap> YKSAVR_DeviceTypeChannelIndexMap { get; set; }
        public virtual DbSet<YKSAVR_Dossier> YKSAVR_Dossier { get; set; }
        public virtual DbSet<YKSAVR_DossierInside> YKSAVR_DossierInside { get; set; }
        public virtual DbSet<YKSAVR_DossierItem> YKSAVR_DossierItem { get; set; }
        public virtual DbSet<YKSAVR_ENoteAnswer> YKSAVR_ENoteAnswer { get; set; }
        public virtual DbSet<YKSAVR_ENoteAsk> YKSAVR_ENoteAsk { get; set; }
        public virtual DbSet<YKSAVR_ENoteData> YKSAVR_ENoteData { get; set; }
        public virtual DbSet<YKSAVR_ENoteETemplate> YKSAVR_ENoteETemplate { get; set; }
        public virtual DbSet<YKSAVR_ENoteType> YKSAVR_ENoteType { get; set; }
        public virtual DbSet<YKSAVR_GAZZRY> YKSAVR_GAZZRY { get; set; }
        public virtual DbSet<YKSAVR_ItemData> YKSAVR_ItemData { get; set; }
        public virtual DbSet<YKSAVR_OperationType> YKSAVR_OperationType { get; set; }
        public virtual DbSet<YKSAVR_Phrase> YKSAVR_Phrase { get; set; }
        public virtual DbSet<YKSAVR_RoomChannel> YKSAVR_RoomChannel { get; set; }
        public virtual DbSet<YKSAVR_Room_duofangjian> YKSAVR_Room_duofangjian { get; set; }
        public virtual DbSet<YKSAVR_RoomGroup> YKSAVR_RoomGroup { get; set; }
        public virtual DbSet<YKSAVR_RoomGroupMember> YKSAVR_RoomGroupMember { get; set; }
        public virtual DbSet<YKSAVR_RoomPoint> YKSAVR_RoomPoint { get; set; }
        public virtual DbSet<YKSAVR_Server> YKSAVR_Server { get; set; }
        public virtual DbSet<YKSAVR_ServerRoom> YKSAVR_ServerRoom { get; set; }
        public virtual DbSet<YKSAVR_ServerType> YKSAVR_ServerType { get; set; }
        public virtual DbSet<YKSAVR_Vendor> YKSAVR_Vendor { get; set; }
        public virtual DbSet<YKSAVR_VideoFiles> YKSAVR_VideoFiles { get; set; }
        public virtual DbSet<YKSAVR_VideoMark> YKSAVR_VideoMark { get; set; }
        public virtual DbSet<YKSAVR_VideoRecord> YKSAVR_VideoRecord { get; set; }
        public virtual DbSet<YKSAVR_ViewGroup> YKSAVR_ViewGroup { get; set; }
        public virtual DbSet<YKSAVR_ViewGroupMember> YKSAVR_ViewGroupMember { get; set; }
        public virtual DbSet<YKTV_ArriveReason> YKTV_ArriveReason { get; set; }
        public virtual DbSet<YKTV_Belongings> YKTV_Belongings { get; set; }
        public virtual DbSet<YKTV_Card> YKTV_Card { get; set; }
        public virtual DbSet<YKTV_CaseItemInStock> YKTV_CaseItemInStock { get; set; }
        public virtual DbSet<YKTV_CertificateType> YKTV_CertificateType { get; set; }
        public virtual DbSet<YKTV_PersonInCase> YKTV_PersonInCase { get; set; }
        public virtual DbSet<YKTV_PersonInfoCollect> YKTV_PersonInfoCollect { get; set; }
        public virtual DbSet<YKTV_PersonType> YKTV_PersonType { get; set; }
        public virtual DbSet<YKTV_Photos> YKTV_Photos { get; set; }
        public virtual DbSet<YKTV_ReaderChannel> YKTV_ReaderChannel { get; set; }
        public virtual DbSet<YKTV_ReaderDevice> YKTV_ReaderDevice { get; set; }
        public virtual DbSet<YKTV_ReaderRoom> YKTV_ReaderRoom { get; set; }
        public virtual DbSet<YKTV_RoomReservation> YKTV_RoomReservation { get; set; }
        public virtual DbSet<YKTV_SaftyCheck> YKTV_SaftyCheck { get; set; }
        public virtual DbSet<YKTV_Trace> YKTV_Trace { get; set; }
        public virtual DbSet<YKTV_Units> YKTV_Units { get; set; }
        public virtual DbSet<BaseArea> BaseAreas { get; set; }
        public virtual DbSet<district_area> district_area { get; set; }
        public virtual DbSet<district_city> district_city { get; set; }
        public virtual DbSet<district_province> district_province { get; set; }
        public virtual DbSet<YKGA_BLCYY> YKGA_BLCYY { get; set; }
        public virtual DbSet<YKGA_BLMB> YKGA_BLMB { get; set; }
        public virtual DbSet<YKGA_JQXX> YKGA_JQXX { get; set; }
        public virtual DbSet<YKGA_PersonRoomBind> YKGA_PersonRoomBind { get; set; }
        public virtual DbSet<YKGA_RYAQJCXX> YKGA_RYAQJCXX { get; set; }
        public virtual DbSet<YKGA_RYBL> YKGA_RYBL { get; set; }
        public virtual DbSet<YKGA_RYCJXX> YKGA_RYCJXX { get; set; }
        public virtual DbSet<YKGA_RYWPDJXX> YKGA_RYWPDJXX { get; set; }
        public virtual DbSet<YKGA_SACW> YKGA_SACW { get; set; }
        public virtual DbSet<YKGA_SACWRZ> YKGA_SACWRZ { get; set; }
        public virtual DbSet<YKGA_SACWZP> YKGA_SACWZP { get; set; }
        public virtual DbSet<YKGA_ZDXX> YKGA_ZDXX { get; set; }
        public virtual DbSet<YKGA_ZDXX0> YKGA_ZDXX0 { get; set; }
        public virtual DbSet<YKSACW_WPCZ> YKSACW_WPCZ { get; set; }
        public virtual DbSet<YKSACW_WPCZMX> YKSACW_WPCZMX { get; set; }
        public virtual DbSet<YKSACW_WPXX> YKSACW_WPXX { get; set; }
        public virtual DbSet<YKSACW_WPZP> YKSACW_WPZP { get; set; }
        public virtual DbSet<YKSAVR_Audio> YKSAVR_Audio { get; set; }
        public virtual DbSet<YKSAVR_CaseTPLink> YKSAVR_CaseTPLink { get; set; }
        public virtual DbSet<YKSAVR_Room> YKSAVR_Room { get; set; }
        public virtual DbSet<YKSAVR_VideoTP> YKSAVR_VideoTP { get; set; }
        public virtual DbSet<YKSAVR_VideoTrial> YKSAVR_VideoTrial { get; set; }
        public virtual DbSet<YKSAVR_VideoTV> YKSAVR_VideoTV { get; set; }
        public virtual DbSet<YKTV_ProcessMode> YKTV_ProcessMode { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseBillPush>()
                .Property(e => e.SubscriptionCategory)
                .HasPrecision(53, 0);

            modelBuilder.Entity<BaseBillPush>()
                .Property(e => e.SubscriptionStatus)
                .HasPrecision(53, 0);

            modelBuilder.Entity<BaseComment>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BaseHoliday>()
                .Property(e => e.Holiday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BaseKnowledge>()
                .Property(e => e.PriorityId)
                .IsUnicode(false);

            modelBuilder.Entity<BaseKnowledge>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BaseMessage>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.TableCode)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.ColumnCode)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.DataType)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.TargetTable)
                .IsUnicode(false);

            modelBuilder.Entity<BaseTableColumn>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<BaseUser>()
                .HasOptional(e => e.BaseUserContact)
                .WithRequired(e => e.BaseUser);

            modelBuilder.Entity<BaseUser>()
                .HasOptional(e => e.BaseUserLogOn)
                .WithRequired(e => e.BaseUser);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<OptionItemsExpress>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<OptionItemsExpress>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<OptionItemsPayCategory>()
                .Property(e => e.ItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<OptionItemsPayCategory>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<YKGA_PersonRoomBind0>()
                .Property(e => e.RoomId)
                .IsUnicode(false);

            modelBuilder.Entity<YKGA_PersonRoomBind0>()
                .Property(e => e.PersonId)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_Dossier>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_Dossier>()
                .Property(e => e.PoliceCaseId)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.dossier_index)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.dossier_police)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.police_name)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.police_no)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.police_idcard)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.inquested_index)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.inquested_type)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.CaseId)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.PoliceCaseId)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_DossierInside>()
                .Property(e => e.FacePersonId)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_OperationType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_Phrase>()
                .Property(e => e.Sentence)
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_VideoFiles>()
                .Property(e => e.FileSize)
                .HasPrecision(53, 0);

            modelBuilder.Entity<YKSACW_WPCZMX>()
                .Property(e => e.zpid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<YKSAVR_VideoTP>()
                .Property(e => e.FileSize)
                .HasPrecision(53, 0);

            modelBuilder.Entity<YKSAVR_VideoTV>()
                .Property(e => e.FileSize)
                .HasPrecision(53, 0);
        }
    }
}
