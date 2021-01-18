using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Motivo_de_Cancelacion_del_Proceso
{
    public interface IMotivo_de_Cancelacion_del_ProcesoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_ProcesoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Motivo_de_Cancelacion_del_ProcesoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso entity, Spartane.Core.Domain.User.GlobalData Motivo_de_Cancelacion_del_ProcesoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso entity, Spartane.Core.Domain.User.GlobalData Motivo_de_Cancelacion_del_ProcesoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_ProcesoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Motivo_de_Cancelacion_del_Proceso.Motivo_de_Cancelacion_del_Proceso_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

