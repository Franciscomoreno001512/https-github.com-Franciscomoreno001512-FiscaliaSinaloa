using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Medida_de_Proteccion
{
    public interface IMedida_de_ProteccionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_ProteccionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Medida_de_ProteccionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion entity, Spartane.Core.Domain.User.GlobalData Medida_de_ProteccionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion entity, Spartane.Core.Domain.User.GlobalData Medida_de_ProteccionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_ProteccionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

