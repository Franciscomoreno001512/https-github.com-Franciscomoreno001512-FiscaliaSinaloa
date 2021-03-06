﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Pais;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Pais
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class PaisService : IPaisService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Pais.Pais> _PaisRepository;
        #endregion

        #region Ctor
        public PaisService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Pais.Pais> PaisRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._PaisRepository = PaisRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Pais.Pais> SelAll(bool ConRelaciones)
        {
            return this._PaisRepository.Table.ToList();
        }

        public IList<Core.Domain.Pais.Pais> SelAllComplete(bool ConRelaciones)
        {
            return this._PaisRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Pais.Pais> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PaisRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Pais.Pais> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._PaisRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Pais.Pais> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PaisRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Pais.PaisPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            PaisPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Pais.Pais> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._PaisRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Pais.Pais GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Pais.Pais result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData PaisInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Pais.Pais entity, Spartane.Core.Domain.User.GlobalData PaisInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Pais.Pais entity, Spartane.Core.Domain.User.GlobalData PaisInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

