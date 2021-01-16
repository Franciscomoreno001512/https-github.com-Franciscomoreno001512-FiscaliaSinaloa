﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_queja_sugerencia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_queja_sugerencia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_queja_sugerenciaService : IEstatus_queja_sugerenciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia> _Estatus_queja_sugerenciaRepository;
        #endregion

        #region Ctor
        public Estatus_queja_sugerenciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia> Estatus_queja_sugerenciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_queja_sugerenciaRepository = Estatus_queja_sugerenciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia> SelAll(bool ConRelaciones)
        {
            return this._Estatus_queja_sugerenciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_queja_sugerenciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_queja_sugerenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_queja_sugerenciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_queja_sugerenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_queja_sugerenciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_queja_sugerenciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_queja_sugerenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia entity, Spartane.Core.Domain.User.GlobalData Estatus_queja_sugerenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_queja_sugerencia.Estatus_queja_sugerencia entity, Spartane.Core.Domain.User.GlobalData Estatus_queja_sugerenciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

