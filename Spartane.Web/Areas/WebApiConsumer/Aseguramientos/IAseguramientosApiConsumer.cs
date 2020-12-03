using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Aseguramientos
{
    public interface IAseguramientosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Aseguramientos.Aseguramientos> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Aseguramientos.AseguramientosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData AseguramientosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Aseguramientos.Aseguramientos entity, Spartane.Core.Domain.User.GlobalData AseguramientosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Aseguramientos.Aseguramientos entity, Spartane.Core.Domain.User.GlobalData AseguramientosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Aseguramientos.AseguramientosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Aseguramientos.Aseguramientos_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Medios_de_Transporte_Involucrados(Spartane.Core.Domain.Aseguramientos.Aseguramientos_Medios_de_Transporte_Involucrados entity);
		ApiResponse<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Medios_de_Transporte_Involucrados> Get_Medios_de_Transporte_Involucrados(string Key);

		ApiResponse<int> Update_Drogas_Involucradas(Spartane.Core.Domain.Aseguramientos.Aseguramientos_Drogas_Involucradas entity);
		ApiResponse<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Drogas_Involucradas> Get_Drogas_Involucradas(string Key);

		ApiResponse<int> Update_Armas_Involucradas(Spartane.Core.Domain.Aseguramientos.Aseguramientos_Armas_Involucradas entity);
		ApiResponse<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Armas_Involucradas> Get_Armas_Involucradas(string Key);

		ApiResponse<int> Update_Objetos_Asegurados(Spartane.Core.Domain.Aseguramientos.Aseguramientos_Objetos_Asegurados entity);
		ApiResponse<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Objetos_Asegurados> Get_Objetos_Asegurados(string Key);

		ApiResponse<int> Update_Otros_Aseguramientos(Spartane.Core.Domain.Aseguramientos.Aseguramientos_Otros_Aseguramientos entity);
		ApiResponse<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Otros_Aseguramientos> Get_Otros_Aseguramientos(string Key);


    }
}

