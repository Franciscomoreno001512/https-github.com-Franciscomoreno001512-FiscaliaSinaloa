using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Datos_de_Delito_MPI
{
    public interface IDetalle_Datos_de_Delito_MPIApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPIPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Datos_de_Delito_MPIInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI entity, Spartane.Core.Domain.User.GlobalData Detalle_Datos_de_Delito_MPIInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI entity, Spartane.Core.Domain.User.GlobalData Detalle_Datos_de_Delito_MPIInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPIPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Datos_de_Robo_de_Vehiculo(Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI_Datos_de_Robo_de_Vehiculo entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI_Datos_de_Robo_de_Vehiculo> Get_Datos_de_Robo_de_Vehiculo(string Key);

		ApiResponse<int> Update_Datos_del_Levantamiento_del_Cadaver_(Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI_Datos_del_Levantamiento_del_Cadaver_ entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Datos_de_Delito_MPI.Detalle_Datos_de_Delito_MPI_Datos_del_Levantamiento_del_Cadaver_> Get_Datos_del_Levantamiento_del_Cadaver_(string Key);


    }
}

