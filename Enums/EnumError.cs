using EVE.Commons.Attribute;

namespace EVE.Commons
{
    public enum EnumError
    {
        #region 400xxx

        [StringValue("Chi tiết không được để trống")]
        ArrayDetailIsNullOrEmpty = 400000,

        [StringValue("Tên đăng nhập không được để trống")]
        UserNameIsNullOrEmpty = 400100,

        [StringValue("Mật khẩu không được để trống")]
        PasswordIsNullOrEmpty = 400200,

        [StringValue("Nhóm người dùng không được để trống")]
        UserClassIsNullOrEmpty = 400300,

        [StringValue("EmployeeId không được để trống")]
        EmployeeIdIsNullOrEmpty = 400400,

        [StringValue("Mã khách hàng không được để trống")]
        AgentIdIsNullOrEmpty = 400500,

        [StringValue("Khu vực không được để trống")]
        AreaIsNullOrEmpty = 400600,

        [StringValue("Stack không được để trống")]
        StackIsNullOrEmpty = 400700,

        [StringValue("CodeTp không được để trống")]
        CodeTpIsNullOrEmpty = 400800,

        [StringValue("CodeRef không được để trống")]
        CodeRefIsNullOrEmpty = 400900,

        [StringValue("MENU_MODULE không được để trống")]
        MenuModuleIsNullOrEmpty = 400010,

        [StringValue("GROUP_CODE không được để trống")]
        GroupCodeIsNullOrEmpty = 400110,

        [StringValue("MENU_ITEM_CODE không được để trống")]
        MenuItemCodeIsNullOrEmpty = 400210,

        [StringValue("OPERATION_METHOD không được để trống")]
        OperationMethodIsNullOrEmpty = 400310,

        [StringValue("LINE_OPER không được để trống")]
        LineOperIsNullOrEmpty = 400410,

        [StringValue("DEPOT không được để trống")]
        DepotIsNullOrEmpty = 400510,

        [StringValue("Mã khách hàng không được để trống")]
        CustomerNoIsNullOrEmpty = 400610,

        [StringValue("Tên [Phòng giáo dục] không được để trống")]
        EduDepartmentNameIsNullOrEmpty = 400710,

        [StringValue("Module Code không được để trống")]
        ModuleCodeIsNullOrEmpty = 400810,

        [StringValue("Truck key không được để trống")]
        TruckKeyIsNullOrEmpty = 400910,

        [StringValue("Truck key không được để trống")]
        MenuItemActionCodeIsNullOrEmpty = 400020,

        [StringValue("EIR_ID không được để trống")]
        EirIdIsNullOrEmpty = 400120,

        [StringValue("TRK_ID không được để trống")]
        TrkIdIsNullOrEmpty = 400220,

        [StringValue("VES_CD không được để trống")]
        VesCdIsNullOrEmpty = 400320,

        [StringValue("PORT không được để trống")]
        PortIsNullOrEmpty = 400420,

        #endregion

        #region 500xxx

        [StringValue("Something wrong :(")]
        BadRequest = 590000,

        [StringValue("Tên đăng nhập hoặc mật khẩu không chính xác")]
        LogonInvalid = 590100,

        [StringValue("Người dùng không thuộc nhóm này")]
        UserClassInvalid = 590200,

        [StringValue("Mã khách hàng đã tồn tại")]
        AgentHasExist = 590300,

        [StringValue("Khách hàng không tồn tại")]
        AgentNotExist = 590400,

        [StringValue("Phòng đào tạo đã tồn tại")]
        EduDepartmentHasExist = 590500,

        [StringValue("Phòng đào tạo không tồn tại")]
        EduDepartmentNotExist = 590600,

        [StringValue("Nhân viên đã tồn tại")]
        EmployeeHasExist = 590700,

        [StringValue("Nhân viên không tồn tại")]
        EmployeeNotExist = 590800,

        [StringValue("Nhân viên đã tồn tại")]
        MenuGroupHasExist = 590900,

        [StringValue("MenuGroup không tồn tại")]
        MenuGroupNotExist = 590010,

        [StringValue("Sở giáo dục đã tồn tại")]
        EduProvinceHasExist = 590110,

        [StringValue("Sở giáo dục không tồn tại")]
        EduProvinceNotExist = 590210,

        [StringValue("Tiêu chí đã tồn tại")]
        EvalCriteriaHasExist = 590310,

        [StringValue("Tiêu chí không tồn tại")]
        EvalCriteriaNotExist = 590410,

        [StringValue("EvalDetail đã tồn tại")]
        EvalDetailHasExist = 590510,

        [StringValue("EvalDetail không tồn tại")]
        EvalDetailNotExist = 590610,

        [StringValue("EvalGuide đã tồn tại")]
        EvalGuideHasExist = 590710,

        [StringValue("EvalGuide không tồn tại")]
        EvalGuideNotExist = 590810,

        [StringValue("UserGroupEmployee đã tồn tại")]
        UserGroupEmployeeHasExist = 590910,

        [StringValue("UserGroupEmployee không tồn tại")]
        UserGroupEmployeeNotExist = 590020,

        [StringValue("EvalMaster đã tồn tại")]
        EvalMasterHasExist = 590120,

        [StringValue("EvalMaster không tồn tại")]
        EvalMasterNotExist = 590220,

        [StringValue("EvalPeriod đã tồn tại")]
        EvalPeriodHasExist = 590320,

        [StringValue("EvalPeriod không tồn tại")]
        EvalPeriodNotExist = 590420,

        [StringValue("Phân quyền cho nhóm người dùng này đã tồn tại")]
        UserClassMenuItemHasExist = 590520,

        [StringValue("Phân quyền cho nhóm người dùng này không tồn tại")]
        UserClassMenuItemNotExist = 590620,


        [StringValue("EvalResult đã tồn tại")]
        EvalResultHasExist = 500000,

        [StringValue("EvalResult không tồn tại")]
        EvalResultNotExist = 500010,

        [StringValue("Nhóm người dùng cho user này không tồn tại")]
        OperatorUserClassSiteNotExist = 500020,

        [StringValue("Nhóm người dùng cho user này đã tồn tại")]
        OperatorUserClassSiteHasExist = 500030,

        [StringValue("Menu item action cho nhóm người dùng này không tồn tại")]
        UserClassFormActionNotExist =500040,

        [StringValue("EvalStandard này không tồn tại")]
        EvalStandardNotExist = 500050,

        [StringValue("EvalStandard này đã tồn tại")]
        EvalStandardHasExist = 500060,

        [StringValue("EvalState này không tồn tại")]
        EvalStateNotExist = 500070,

        [StringValue("EvalState này đã tồn tại")]
        EvalStateHasExist = 500080,

        [StringValue("EvalTypeBE này không tồn tại")]
        EvalTypeBENotExist = 500090,

        [StringValue("EvalTypeBE này đã tồn tại")]
        EvalTypeBEHasExist = 500100,

        [StringValue("FormGroup này không tồn tại")]
        FormGroupNotExist = 500110,

        [StringValue("FormGroup này đã tồn tại")]
        FormGroupHasExist = 500120,

        [StringValue("FormCode này không tồn tại")]
        FormsNotExist = 500130,

        [StringValue("FormCode này đã tồn tại")]
        FormsHasExist = 500140,

        [StringValue("LoginUser này không tồn tại")]
        LoginUserNotExist = 500150,

        [StringValue("LoginUser này đã tồn tại")]
        LoginUserHasExist = 500160,

        [StringValue("School này không tồn tại")]
        SchoolNotExist = 500170,

        [StringValue("School này đã tồn tại")]
        SchoolHasExist = 500180,

        [StringValue("SchoolLevel này không tồn tại")]
        SchoolLevelNotExist = 500190,

        [StringValue("SchoolLevel này đã tồn tại")]
        SchoolLevelHasExist = 500200,

        [StringValue("UserGroup này không tồn tại")]
        UserGroupNotExist = 500210,

        [StringValue("UserGroup này đã tồn tại")]
        UserGroupHasExist = 500220,

        [StringValue("UserGroupForm này không tồn tại")]
        UserGroupFormNotExist = 500230,

        [StringValue("UserGroupForm này đã tồn tại")]
        UserGroupFormHasExist = 500240,

        [StringValue("EvalType này không tồn tại")]
        EvalTypeNotExist = 500250,

        [StringValue("Ward này không tồn tại")]
        WardNotExist = 500260,
        [StringValue("Province này không tồn tại")]
        ProvinceNotExist = 500270,

        [StringValue("District này không tồn tại")]
        DistrictNotExist = 500280,

        [StringValue("Country này không tồn tại")]
        CountryNotExist = 500290,

        [StringValue("User này chưa được cấp quyền")]
        UserNotGrandPermission = 500300,

        [StringValue("Không tồn tại tiêu chí của tiêu chuẩn này")]
        CateriaNotExistWithStandard = 500310,

        [StringValue("Chức danh này không tồn tại")]
        PositionNotExist = 500320,

        [StringValue("Tên kỳ đánh giá không được để trống")]
        PeriodNameCanNotBeNull = 500330,

        [StringValue("[Năm] không được để trống")]
        YearCanNotBeNull = 500340,

        [StringValue("[Từ ngày] không được để trống")]
        FromDateCanNotBeNull = 500350,

        [StringValue("[Đến ngày] không được để trống")]
        ToDateCanNotBeNull = 500360,

        [StringValue("[Sở giáo dục] không được để trống")]
        EduProvinceIdIsNullOrEmpty = 500370,

        [StringValue("[Quận/Huyện] không được để trống")]
        DistrictIdIsNullOrEmpty = 500380,

        [StringValue("Tên [Sở giáo dục] không được để trống")]
        EduProvinceNameIsNullOrEmpty = 500390,

        [StringValue("[Tỉnh] không được để trống")]
        ProvinceIdIsNullOrEmpty = 500400,

        [StringValue("[Tên nhân viên] không được để trống")]
        EmployeeNameIsNullOrEmpty = 500410,

        [StringValue("[Mã phòng giáo dục] không được để trống")]
        EduDepartmentIdNullOrEmpty = 500420,

        [StringValue("[UserName] đã tồn tại!")]
        UserNameHasExits= 500430,

        [StringValue("[Cấp giáo dục] không được để trống")]
        EduLevelCodeIsNullOrEmpty = 500440,

        [StringValue("[Tiêu chuẩn] không được để trống")]
        EvalStandardIdIsNullOrEmpty = 500450,

        [StringValue("[Tiêu chí] không được để trống")]
        EvalCriteriaNameIsNullOrEmpty = 500460,

        [StringValue("[Số thứ tự] không được để trống")]
        IdxIsNullOrEmpty = 500250,

        [StringValue("[ID Tiêu chí] không được để trống")]
        EvalCriteriaIdNullOrEmpty = 500470,

        [StringValue("[ID Tiêu chí nhân viên] không được để trống")]
        EvalDetailIdIsNullOrEmpty = 500480,

        [StringValue("[Tiêu chuẩn] không được để trống")]
        EvalMasterIsNullOrEmpty = 500490,
        
        [StringValue("[Tiêu chí] không được để trống")]
        EvalCriteriaIsNullOrEmpty = 500500,


        [StringValue("[Người đánh giá] không được để trống")]
        EmployeeIsNullOrEmpty = 500510,

        [StringValue("[Người được đánh giá] không được để trống")]
        EvalForEmployeeIsNullOrEmpty = 500520,

        [StringValue("[Mã kết quả đánh giá] không được để trống")]
        EvalResultCodeIsNullOrEmpty = 500530,

        [StringValue("[Kết quả đánh giá] không được để trống")]
        EvalResultNameIsNullOrEmpty = 500540,

        [StringValue("[Chuẩn đánh giá] không được để trống")]
        EvalStandardNameIsNullOrEmpty = 500550,

        [StringValue("[Loại đánh giá] không được để trống")]
        EvalTypeCodeIsNullOrEmpty = 500560,


        [StringValue("[Cấp trường] không được để trống")]
        SchoolLevelCodeIsNullOrEmpty = 500570,

        [StringValue("[Nhóm quyền] không được để trống")]
        UserGroupCodeIsNullOrEmpty = 500580,

        [StringValue("[Tên nhóm quyền] không được để trống")]
        UserGroupNameIsNullOrEmpty = 500590,

        [StringValue("[Mã Form] không được để trống")]
        FormCodeIsNullOrEmpty = 500600,

        [StringValue("[Cấp giáo dục] không tồn tại")]
        EduLevelNotExist = 500610,

        [StringValue("[Thông tin trường] không được phép trống!")]
        SchoolIsNullOrEmpty = 500620,

        [StringValue("[Mã trường] không được phép trống!")]
        SchoolIdIsNullOrEmpty = 500630,

        [StringValue("[Năm] không được phép trống!")]
        YearIsNullOrEmpty = 500640,

        [StringValue("[Insert] thất bại!")]
        InsertFailse = 500650,

        [StringValue("[Update] thất bại!")]
        UpdateFailse = 500660,

        [StringValue("[Delete] thất bại!")]
        DeleteFailse = 500670,

        [StringValue("[Mã nhân viên đánh giá] không được để trống!")]
        EvalEmployeeIdIsNullOrEmpty = 500680,

        [StringValue("[Mã nhân viên được đánh giá] không được để trống!")]
        BeEvalEmployeeIdIsNullOrEmpty = 500690,

        [StringValue("[Mã kỳ đánh giá] không được để trống!")]
        PeriodIdIsNullOrEmpty = 500700,
        #endregion

        [StringValue("Không tìm thấy dữ liệu!")]
        DataNotFound = 700000,

    }
}
