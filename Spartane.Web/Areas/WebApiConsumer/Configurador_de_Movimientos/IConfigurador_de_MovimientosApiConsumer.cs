using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Configurador_de_Movimientos
{
    public interface IConfigurador_de_MovimientosApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_MovimientosPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Configurador_de_MovimientosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos entity, Spartane.Core.Domain.User.GlobalData Configurador_de_MovimientosInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos entity, Spartane.Core.Domain.User.GlobalData Configurador_de_MovimientosInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_MovimientosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

