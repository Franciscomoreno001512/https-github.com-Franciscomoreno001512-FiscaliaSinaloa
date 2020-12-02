using System;
using Spartane.Core.Domain.Marca_de_Arma;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Marca_de_Arma
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IMarca_de_ArmaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Marca_de_Arma.Marca_de_ArmaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Marca_de_Arma.Marca_de_Arma> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
