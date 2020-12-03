using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Audiencia_Archivos_Adjuntos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Audiencia_Archivos_AdjuntosService : IDetalle_Audiencia_Archivos_AdjuntosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos> _Detalle_Audiencia_Archivos_AdjuntosRepository;
        #endregion

        #region Ctor
        public Detalle_Audiencia_Archivos_AdjuntosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos> Detalle_Audiencia_Archivos_AdjuntosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Audiencia_Archivos_AdjuntosRepository = Detalle_Audiencia_Archivos_AdjuntosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Audiencia_Archivos_AdjuntosRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Audiencia_Archivos_AdjuntosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Audiencia_Archivos_AdjuntosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Audiencia_Archivos_AdjuntosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Audiencia_Archivos_AdjuntosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_AdjuntosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Audiencia_Archivos_AdjuntosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Audiencia_Archivos_AdjuntosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Audiencia_Archivos_AdjuntosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos entity, Spartane.Core.Domain.User.GlobalData Detalle_Audiencia_Archivos_AdjuntosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos.Detalle_Audiencia_Archivos_Adjuntos entity, Spartane.Core.Domain.User.GlobalData Detalle_Audiencia_Archivos_AdjuntosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

