using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Discapacidades_Fisicas
{
    public interface IDiscapacidades_FisicasApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_FisicasPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Discapacidades_FisicasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas entity, Spartane.Core.Domain.User.GlobalData Discapacidades_FisicasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas entity, Spartane.Core.Domain.User.GlobalData Discapacidades_FisicasInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_FisicasPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

