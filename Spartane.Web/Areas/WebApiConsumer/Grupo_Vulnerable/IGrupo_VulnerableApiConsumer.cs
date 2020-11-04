using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Grupo_Vulnerable
{
    public interface IGrupo_VulnerableApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_VulnerablePagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Grupo_VulnerableInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable entity, Spartane.Core.Domain.User.GlobalData Grupo_VulnerableInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable entity, Spartane.Core.Domain.User.GlobalData Grupo_VulnerableInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_VulnerablePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Grupo_Vulnerable.Grupo_Vulnerable_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

