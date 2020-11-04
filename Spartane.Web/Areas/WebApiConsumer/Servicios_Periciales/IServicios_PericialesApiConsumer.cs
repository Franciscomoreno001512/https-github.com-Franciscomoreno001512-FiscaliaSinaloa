using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales
{
    public interface IServicios_PericialesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Servicios_Periciales.Servicios_PericialesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Servicios_PericialesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales entity, Spartane.Core.Domain.User.GlobalData Servicios_PericialesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales entity, Spartane.Core.Domain.User.GlobalData Servicios_PericialesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Servicios_Periciales.Servicios_PericialesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Servicios_Periciales.Servicios_Periciales_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

