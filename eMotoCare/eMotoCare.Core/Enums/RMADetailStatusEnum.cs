namespace eMotoCare.Core.Enums
{
    public enum RMADetailStatusEnum
    {
        //mới ghi nhận lỗi/phụ tùng
        CREATED,
        //Chờ kiểm tra
        WAITINGINSPECTION,
        //Đang kiểm tra
        INSPECTING,
        // Chờ quyết định bảo hành
        PEDINGDECISTION,
        //Được duyệt bảo hành
        APPROVED,
        // Bị từ chối bảo hành
        REJECTED,
        // Chờ link kiện thay thế
        WAITING_PARTS,
        //Đang sửa chữa
        REPAIRING,
        //Đã thay thế
        REPLACED,
        // Đã sửa xong
        REPAIRED,
        //Chờ trả khách
        WAITING_RETURN,
        //Hoàn tất xử lý detail
        COMPLETED,
        //Hủy xử lý
        CANCLLED
    }
}