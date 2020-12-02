using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Metodo_de_Destruccion
{
    public interface IMetodo_de_DestruccionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_DestruccionPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Metodo_de_DestruccionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion entity, Spartane.Core.Domain.User.GlobalData Metodo_de_DestruccionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion entity, Spartane.Core.Domain.User.GlobalData Metodo_de_DestruccionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_DestruccionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

