using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Otros_Domicilios_Involucrado
{
    public interface IOtros_Domicilios_InvolucradoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_InvolucradoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Otros_Domicilios_InvolucradoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado entity, Spartane.Core.Domain.User.GlobalData Otros_Domicilios_InvolucradoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado entity, Spartane.Core.Domain.User.GlobalData Otros_Domicilios_InvolucradoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_InvolucradoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Otros_Domicilios_Involucrado.Otros_Domicilios_Involucrado_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

