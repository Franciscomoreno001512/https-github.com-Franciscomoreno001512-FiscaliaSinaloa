using System;
using Spartane.Core.Domain.Recepcion_de_Pago_MASC;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Recepcion_de_Pago_MASC
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IRecepcion_de_Pago_MASCService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASC> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASC> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASC> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASC GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASC entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASC> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASC> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Recepcion_de_Pago_MASC.Recepcion_de_Pago_MASC> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
