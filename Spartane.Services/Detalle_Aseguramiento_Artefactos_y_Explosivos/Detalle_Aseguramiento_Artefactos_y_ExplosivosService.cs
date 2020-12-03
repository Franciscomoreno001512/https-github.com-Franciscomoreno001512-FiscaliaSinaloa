using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Aseguramiento_Artefactos_y_Explosivos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Aseguramiento_Artefactos_y_ExplosivosService : IDetalle_Aseguramiento_Artefactos_y_ExplosivosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> _Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository;
        #endregion

        #region Ctor
        public Detalle_Aseguramiento_Artefactos_y_ExplosivosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository = Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_ExplosivosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Aseguramiento_Artefactos_y_ExplosivosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Aseguramiento_Artefactos_y_ExplosivosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_Artefactos_y_ExplosivosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_Artefactos_y_ExplosivosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Aseguramiento_Artefactos_y_Explosivos.Detalle_Aseguramiento_Artefactos_y_Explosivos entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_Artefactos_y_ExplosivosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

