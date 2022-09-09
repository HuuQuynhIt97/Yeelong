export interface Chemical {
    id: number;
    name: string;
    materialNo: string;
    supplier: string;
    code: string;
    createDate: string | null;
    createBy: number | null;
    updateDate: string | null;
    updateBy: number | null;
    deleteDate: string | null;
    deleteBy: number | null;
    status: number | null;
    guid: string;
}