using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Compania_de_Seguros
{
    public interface ICompania_de_SegurosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_SegurosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Compania_de_SegurosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros entity, Spartane.Core.Domain.User.GlobalData Compania_de_SegurosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros entity, Spartane.Core.Domain.User.GlobalData Compania_de_SegurosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_SegurosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

