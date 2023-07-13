namespace Moh.Xml130
{
    //TRẠNG THÁI KHÁM BỆNH, CHỮA BỆNH
    public class XML0 
    {
        public int MA_LK { get; set; }
        public int STT { get; set; }
        public string MA_BN { get; set; }
        public string HO_TEN { get; set; }
        public string SO_CCCD { get; set; }
        public string NGAY_SINH { get; set; }
        public int GIOI_TINH { get; set; }
        public string MA_THE_BHYT { get; set; }
        public string MA_DKBD { get; set; }
        public string GT_THE_TU { get; set; }
        public string GT_THE_DEN { get; set; }
        public int MA_DOITUONG_KCB { get; set; }
        public string NGAY_VAO { get; set; }
        public int MA_LOAI_KCB { get; set; }
        public string MA_CSKCB { get; set; }
        public string MA_DICH_VU { get; set; }
        public string TEN_DICH_VU { get; set; }
        public string NGAY_YL { get; set; }
    }
    //TỔNG HỢP KHÁM BỆNH, CHỮA BỆNH
    public class XML1 
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string MA_BN { get; set; }
        public string HO_TEN { get; set; }
        public int SO_CCCD { get; set; }
        public string NGAY_SINH { get; set; }
        public int GIOI_TINH { get; set; }
        public int MA_QUOCTICH { get; set; }
        public int MA_DANTOC { get; set; }
        public int MA_NGHE_NGHIEP { get; set; }
        public string DIA_CHI { get; set; }
        public string MATINH_CU_TRU { get; set; }
        public string MAHUYEN_CU_TRU { get; set; }
        public string MAXA_CU_TRU { get; set; }
        public int DIEN_THOAI { get; set; }
        public string MA_THE_BHYT { get; set; }
        public string MA_DKBD { get; set; }
        public string GT_THE_TU { get; set; }
        public string GT_THE_DEN { get; set; }
        public string NGAY_MIEN_CCT { get; set; }
        public string LY_DO_VV { get; set; }
        public string LY_DO_VNT { get; set; }
        public string MA_LY_DO_VNT { get; set; }
        public string CHAN_DOAN_VAO { get; set; }
        public string CHAN_DOAN_RV { get; set; }
        public string MA_BENH_CHINH { get; set; }
        public string MA_BENH_KT { get; set; }
        public string MA_BENH_YHCT { get; set; }
        public string MA_PTTT_QT { get; set; }
        public string MA_DOITUONG_KCB { get; set; }
        public string MA_NOI_DI { get; set; }
        public string MA_NOI_DEN { get; set; }
        public int MA_TAI_NAN { get; set; }
        public string NGAY_VAO { get; set; }
        public string NGAY_VAO_NOI_TRU { get; set; }
        public string NGAY_RA { get; set; }
        public string GIAY_CHUYEN_TUYEN { get; set; }
        public int SO_NGAY_DTRI { get; set; }
        public string PP_DIEU_TRI { get; set; }
        public int KET_QUA_DTRI { get; set; }
        public int MA_LOAI_RV { get; set; }
        public string GHI_CHU { get; set; }
        public string NGAY_TTOAN { get; set; }
        public int T_THUOC { get; set; }
        public int T_VTYT { get; set; }
        public int T_TONGCHI_BV { get; set; }
        public int T_TONGCHI_BH { get; set; }
        public int T_BNTT { get; set; }
        public int T_BNCCT { get; set; }
        public int T_BHTT { get; set; }
        public int T_NGUONKHAC { get; set; }
        public int T_BHTT_GDV { get; set; }
        public int NAM_QT { get; set; }
        public int THANG_QT { get; set; }
        public int MA_LOAI_KCB { get; set; }
        public string MA_KHOA { get; set; }
        public string MA_CSKCB { get; set; }
        public string MA_KHUVUC { get; set; }
        public string CAN_NANG { get; set; }
        public string CAN_NANG_CON { get; set; }
        public string NAM_NAM_LIEN_TUC { get; set; }
        public string NGAY_TAI_KHAM { get; set; }
        public string MA_HSBA { get; set; }
        public string MA_TTDV { get; set; }
        public string DU_PHONG { get; set; }
    }
    //CHI TIẾT THUỐC
    public class XML2 
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string MA_THUOC { get; set; }
        public string MA_PP_CHEBIEN { get; set; }
        public string MA_CSKCB_THUOC { get; set; }
        public int MA_NHOM { get; set; }
        public string TEN_THUOC { get; set; }
        public string DON_VI_TINH { get; set; }
        public string HAM_LUONG { get; set; }
        public string DUONG_DUNG { get; set; }
        public string DANG_BAO_CHE { get; set; }
        public string LIEU_DUNG { get; set; }
        public string CACH_DUNG { get; set; }
        public string SO_DANG_KY { get; set; }
        public string TT_THAU { get; set; }
        public int PHAM_VI { get; set; }
        public int TYLE_TT_BH { get; set; }
        public int SO_LUONG { get; set; }
        public int DON_GIA { get; set; }
        public int THANH_TIEN_BV { get; set; }
        public int THANH_TIEN_BH { get; set; }
        public int T_NGUONKHAC_NS { get; set; }
        public int T_NGUONKHAC_VT { get; set; }
        public int T_NGUONKHAC_VT_TN { get; set; }
        public int T_NGUONKHAC_CL { get; set; }
        public int T_NGUONKHAC { get; set; }
        public int MUC_HUONG { get; set; }
        public int T_BNTT { get; set; }
        public int T_BNCCT { get; set; }
        public int T_BHTT { get; set; }
        public string MA_KHOA { get; set; }
        public string MA_BAC_SI { get; set; }
        public string MA_DICH_VU { get; set; }
        public string NGAY_YL { get; set; }
        public int MA_PTTT { get; set; }
        public int NGUON_CTRA { get; set; }
        public int VET_THUONG_TP { get; set; }
        public string DU_PHONG { get; set; }
    }
    //CHI TIẾT DỊCH VỤ KỸ THUẬT VÀ VẬT TƯ Y TẾ
    public class XML3 
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string MA_DICH_VU { get; set; }
        public string MA_PTTT_QT { get; set; }
        public string MA_VAT_TU { get; set; }
        public int MA_NHOM { get; set; }
        public string GOI_VTYT { get; set; }
        public string TEN_VAT_TU { get; set; }
        public string TEN_DICH_VU { get; set; }
        public string MA_XANG_DAU { get; set; }
        public string DON_VI_TINH { get; set; }
        public int PHAM_VI { get; set; }
        public int SO_LUONG { get; set; }
        public int DON_GIA_BV { get; set; }
        public int DON_GIA_BH { get; set; }
        public string TT_THAU { get; set; }
        public int TYLE_TT_DV { get; set; }
        public int TYLE_TT_BH { get; set; }
        public int THANH_TIEN_BV { get; set; }
        public int THANH_TIEN_BH { get; set; }
        public int T_TRANTT { get; set; }
        public int MUC_HUONG { get; set; }
        public int T_NGUONKHAC_NSNN { get; set; }
        public int T_NGUONKHAC_VTNN { get; set; }
        public int T_NGUONKHAC_VTTN { get; set; }
        public int T_NGUONKHAC_CL { get; set; }
        public int T_NGUONKHAC { get; set; }
        public int T_BNTT { get; set; }
        public int T_BNCCT { get; set; }
        public int T_BHTT { get; set; }
        public string MA_KHOA { get; set; }
        public string MA_GIUONG { get; set; }
        public string MA_BAC_SI { get; set; }
        public string NGUOI_THUC_HIEN { get; set; }
        public string MA_BENH { get; set; }
        public string MA_BENH_YHCT { get; set; }
        public string NGAY_YL { get; set; }
        public string NGAY_TH_YL { get; set; }
        public string NGAY_KQ { get; set; }
        public int MA_PTTT { get; set; }
        public int VET_THUONG_TP { get; set; }
        public int PP_VO_CAM { get; set; }
        public int VI_TRI_TH_DVKT { get; set; }
        public string MA_MAY { get; set; }
        public string MA_HIEU_SP { get; set; }
        public int TAI_SU_DUNG { get; set; }
        public string DU_PHONG { get; set; }
    }
    //CHI TIẾT DỊCH VỤ CẬN LÂM SÀNG
    public class XML4
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string MA_DICH_VU { get; set; }
        public string MA_CHI_SO { get; set; }
        public string TEN_CHI_SO { get; set; }
        public string GIA_TRI { get; set; }
        public string DON_VI_DO { get; set; }
        public string MO_TA { get; set; }
        public string KET_LUAN { get; set; }
        public string NGAY_KQ { get; set; }
        public string MA_BS_DOC_KQ { get; set; }
        public string DU_PHONG { get; set; }
    }
    //CHI TIẾT DIỄN BIẾN LÂM SÀNG
    public class XML5
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string DIEN_BIEN_LS { get; set; }
        public string GIAI_DOAN_BENH { get; set; }
        public string HOI_CHAN { get; set; }
        public string PHAU_THUAT { get; set; }
        public string THOI_DIEM_DBLS { get; set; }
        public string NGUOI_THUC_HIEN { get; set; }
        public string DU_PHONG { get; set; }
    }
    //HỒ SƠ BỆNH ÁN CHĂM SÓC VÀ ĐIỀU TRỊ HIV/AIDS
    public class XML6
    {
        public string MA_LK { get; set; }
        public string MA_THE_BHYT { get; set; }
        public long SO_CCCD { get; set; }
        public string NGAYKD_HIV { get; set; }
        public string BDDT_ARV { get; set; }
        public string MA_PHAC_DO_DIEU_TRI_BD { get; set; }
        public int MA_BAC_PHAC_DO_BD { get; set; }
        public int MA_LYDO_DTRI { get; set; }
        public int LOAI_DTRI_LAO { get; set; }
        public int PHACDO_DTRI_LAO { get; set; }
        public string NGAYBD_DTRI_LAO { get; set; }
        public string NGAYKT_DTRI_LAO { get; set; }
        public int MA_LYDO_XNTL_VR { get; set; }
        public string NGAY_XN_TLVR { get; set; }
        public int KQ_XNTL_VR { get; set; }
        public string NGAY_KQ_XN_TLVR { get; set; }
        public int MA_LOAI_BN { get; set; }
        public string MA_TINH_TRANG_DK { get; set; }
        public int LAN_XN_PCR { get; set; }
        public string NGAY_XN_PCR { get; set; }
        public string NGAY_KQ_XN_PCR { get; set; }
        public int MA_KQ_XN_PCR { get; set; }
        public string NGAY_NHAN_TT_MANG_THAI { get; set; }
        public string NGAY_BAT_DAU_DT_CTX { get; set; }
        public int MA_XU_TRI { get; set; }
        public string NGAY_BAT_DAU_XU_TRI { get; set; }
        public string NGAY_KET_THUC_XU_TRI { get; set; }
        public string MA_PHAC_DO_DIEU_TRI { get; set; }
        public int MA_BAC_PHAC_DO { get; set; }
        public int SO_NGAY_CAP_THUOC_ARV { get; set; }
        public string DU_PHONG { get; set; }
    }
    //DỮ LIỆU GIẤY RA VIỆN
    public class XML7
    {
        public string MA_LK { get; set; }
        public string SO_LUU_TRU { get; set; }
        public string MA_YTE { get; set; }
        public string MA_KHOA_RV { get; set; }
        public string NGAY_VAO { get; set; }
        public string NGAY_RA { get; set; }
        public int MA_DINH_CHI_THAI { get; set; }
        public string NGUYENNHAN_DINHCHI { get; set; }
        public string THOIGIAN_DINHCHI { get; set; }
        public int TUOI_THAI { get; set; }
        public string CHAN_DOAN_RV { get; set; }
        public string PP_DIEUTRI { get; set; }
        public string GHI_CHU { get; set; }
        public string MA_TTDV { get; set; }
        public string MA_BS { get; set; }
        public string TEN_BS { get; set; }
        public string NGAY_CT { get; set; }
        public string MA_CHA { get; set; }
        public string MA_ME { get; set; }
        public string MA_THE_TAM { get; set; }
        public string HO_TEN_CHA { get; set; }
        public string HO_TEN_ME { get; set; }
        public int SO_NGAY_NGHI { get; set; }
        public string NGOAITRU_TUNGAY { get; set; }
        public string NGOAITRU_DENNGAY { get; set; }
    }
    //DỮ LIỆU TÓM TẮT HỒ SƠ BỆNH ÁN
    public class XML8
    {
        public string MA_LK { get; set; }
        public int MA_LOAI_KCB { get; set; }
        public string HO_TEN_CHA { get; set; }
        public string HO_TEN_ME { get; set; }
        public string NGUOI_GIAM_HO { get; set; }
        public string DON_VI { get; set; }
        public string NGAY_VAO { get; set; }
        public string NGAY_RA { get; set; }
        public string CHAN_DOAN_VAO { get; set; }
        public string CHAN_DOAN_RV { get; set; }
        public string QT_BENHLY { get; set; }
        public string TOMTAT_KQ { get; set; }
        public string PP_DIEUTRI { get; set; }
        public string NGAY_SINHCON { get; set; }
        public string NGAY_CONCHET { get; set; }
        public int SO_CONCHET { get; set; }
        public int KET_QUA_DTRI { get; set; }
        public string GHI_CHU { get; set; }
        public int MA_TTDV { get; set; }
        public string NGAY_CT { get; set; }
        public string MA_THE_TAM { get; set; }
        public string DU_PHONG { get; set; }
    }
    //DỮ LIỆU GIẤY CHỨNG SINH
    public class XML9
    {
        public string MA_LK { get; set; }
        public int MA_BHXH_NND { get; set; }
        public string MA_THE_NND { get; set; }
        public string HO_TEN_NND { get; set; }
        public string NGAYSINH_NND { get; set; }
        public int MA_DANTOC_NND { get; set; }
        public int SO_CCCD_NND { get; set; }
        public string NGAYCAP_CCCD_NND { get; set; }
        public string NOICAP_CCCD_NND { get; set; }
        public string NOI_CU_TRU_NND { get; set; }
        public int MA_QUOCTICH { get; set; }
        public string MATINH_CU_TRU { get; set; }
        public string MAHUYEN_CU_TRU { get; set; }
        public string MAXA_CU_TRU { get; set; }
        public string HO_TEN_CHA { get; set; }
        public string MA_THE_TAM { get; set; }
        public string HO_TEN_CON { get; set; }
        public int GIOI_TINH_CON { get; set; }
        public int SO_CON { get; set; }
        public int LAN_SINH { get; set; }
        public int SO_CON_SONG { get; set; }
        public int CAN_NANG_CON { get; set; }
        public string NGAY_SINH_CON { get; set; }
        public string NOI_SINH_CON { get; set; }
        public string TINH_TRANG_CON { get; set; }
        public int SINHCON_PHAUTHUAT { get; set; }
        public int SINHCON_DUOI32TUAN { get; set; }
        public string GHI_CHU { get; set; }
        public string NGUOI_DO_DE { get; set; }
        public string NGUOI_GHI_PHIEU { get; set; }
        public string NGAY_CT { get; set; }
        public string SO { get; set; }
        public string QUYEN_SO { get; set; }
        public int MA_TTDV { get; set; }
    }
    //DỮ LIỆU GIẤY CHỨNG NHẬN NGHỈ DƯỠNG THAI
    public class XML10
    {
        public string MA_LK { get; set; }
        public string SO_SERI { get; set; }
        public string SO_CT { get; set; }
        public int SO_NGAY { get; set; }
        public string DON_VI { get; set; }
        public string CHAN_DOAN_RV { get; set; }
        public string TU_NGAY { get; set; }
        public string DEN_NGAY { get; set; }
        public int MA_TTDV { get; set; }
        public string TEN_BS { get; set; }
        public string MA_BS { get; set; }
        public string NGAY_CT { get; set; }
    }
    //DỮ LIỆU GIẤY CHỨNG NHẬN NGHỈ VIỆC HƯỞNG BẢO HIỂM XÃ HỘI
    public class XML11
    {
        public string MA_LK { get; set; }
        public string SO_CT { get; set; }
        public string SO_SERI { get; set; }
        public string SO_KCB { get; set; }
        public string DON_VI { get; set; }
        public int MA_BHXH { get; set; }
        public string MA_THE_BHYT { get; set; }
        public string CHAN_DOAN_RV { get; set; }
        public string PP_DIEUTRI { get; set; }
        public int MA_DINH_CHI_THAI { get; set; }
        public string NGUYENNHAN_DINHCHI { get; set; }
        public int TUOI_THAI { get; set; }
        public int SO_NGAY_NGHI { get; set; }
        public string TU_NGAY { get; set; }
        public string DEN_NGAY { get; set; }
        public string HO_TEN_CHA { get; set; }
        public string HO_TEN_ME { get; set; }
        public int MA_TTDV { get; set; }
        public string MA_BS { get; set; }
        public string NGAY_CT { get; set; }
        public string MA_THE_TAM { get; set; }
        public string MAU_SO { get; set; }
    }
    //DỮ LIỆU GIÁM ĐỊNH Y KHOA
    public class XML12
    {
        public string NGUOI_CHU_TRI { get; set; }
        public int CHUC_VU { get; set; }
        public string NGAY_HOP { get; set; }
        public string HO_TEN { get; set; }
        public string NGAY_SINH { get; set; }
        public long SO_CCCD { get; set; }
        public string NGAY_CAP_CCCD { get; set; }
        public string NOI_CAP_CCCD { get; set; }
        public string DIA_CHI { get; set; }
        public string MATINH_CU_TRU { get; set; }
        public string MAHUYEN_CU_TRU { get; set; }
        public string MAXA_CU_TRU { get; set; }
        public long MA_BHXH { get; set; }
        public string MA_THE_BHYT { get; set; }
        public string NGHE_NGHIEP { get; set; }
        public string DIEN_THOAI { get; set; }
        public string MA_DOI_TUONG { get; set; }
        public int KHAM_GIAM_DINH { get; set; }
        public string SO_BIEN_BAN { get; set; }
        public int TYLE_TTCT_CU { get; set; }
        public int DANG_HUONG_CHE_DO { get; set; }
        public string NGAY_CHUNG_TU { get; set; }
        public string SO_GIAY_GIOI_THIEU { get; set; }
        public string NGAY_DE_NGHI { get; set; }
        public string MA_DONVI { get; set; }
        public string GIOI_THIEU_CUA { get; set; }
        public string KET_QUA_KHAM { get; set; }
        public string SO_VAN_BAN_CAN_CU { get; set; }
        public int TYLE_TTCT_MOI { get; set; }
        public int TONG_TYLE_TTCT { get; set; }
        public int DANG_KHUYETTAT { get; set; }
        public int MUC_DO_KHUYETTAT { get; set; }
        public string DE_NGHI { get; set; }
        public string DUOC_XACDINH { get; set; }
        public string DU_PHONG { get; set; }
    }

}
