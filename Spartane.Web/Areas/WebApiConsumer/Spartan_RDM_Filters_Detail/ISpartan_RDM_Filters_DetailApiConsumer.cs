using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Spartan_RDM_Filters_Detail
{
    public interface ISpartan_RDM_Filters_DetailApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_DetailPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Spartan_RDM_Filters_DetailInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail entity, Spartane.Core.Domain.User.GlobalData Spartan_RDM_Filters_DetailInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail entity, Spartane.Core.Domain.User.GlobalData Spartan_RDM_Filters_DetailInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_DetailPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Spartan_RDM_Filters_Detail.Spartan_RDM_Filters_Detail_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

