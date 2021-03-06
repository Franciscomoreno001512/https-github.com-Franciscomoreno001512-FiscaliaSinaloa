﻿using System;
using Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Aseguramiento_Otros_Aseguramientos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Aseguramiento_Otros_AseguramientosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_Aseguramientos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_Aseguramientos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_Aseguramientos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_Aseguramientos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_Aseguramientos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_Aseguramientos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_Aseguramientos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_Aseguramientos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_AseguramientosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Aseguramiento_Otros_Aseguramientos.Detalle_Aseguramiento_Otros_Aseguramientos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
