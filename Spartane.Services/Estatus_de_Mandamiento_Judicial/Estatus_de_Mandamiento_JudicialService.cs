﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_de_Mandamiento_Judicial
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_de_Mandamiento_JudicialService : IEstatus_de_Mandamiento_JudicialService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial> _Estatus_de_Mandamiento_JudicialRepository;
        #endregion

        #region Ctor
        public Estatus_de_Mandamiento_JudicialService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial> Estatus_de_Mandamiento_JudicialRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_de_Mandamiento_JudicialRepository = Estatus_de_Mandamiento_JudicialRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial> SelAll(bool ConRelaciones)
        {
            return this._Estatus_de_Mandamiento_JudicialRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_de_Mandamiento_JudicialRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_Mandamiento_JudicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_de_Mandamiento_JudicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_Mandamiento_JudicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_JudicialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_de_Mandamiento_JudicialPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_de_Mandamiento_JudicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_de_Mandamiento_JudicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Mandamiento_JudicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial.Estatus_de_Mandamiento_Judicial entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Mandamiento_JudicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

