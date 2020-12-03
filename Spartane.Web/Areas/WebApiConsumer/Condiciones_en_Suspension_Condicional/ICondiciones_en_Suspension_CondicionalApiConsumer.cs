using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Condiciones_en_Suspension_Condicional
{
    public interface ICondiciones_en_Suspension_CondicionalApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Condiciones_en_Suspension_CondicionalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional entity, Spartane.Core.Domain.User.GlobalData Condiciones_en_Suspension_CondicionalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional entity, Spartane.Core.Domain.User.GlobalData Condiciones_en_Suspension_CondicionalInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

