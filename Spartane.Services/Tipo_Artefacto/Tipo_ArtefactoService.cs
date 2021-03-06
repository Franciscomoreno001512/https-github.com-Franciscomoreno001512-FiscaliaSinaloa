﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_Artefacto;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_Artefacto
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_ArtefactoService : ITipo_ArtefactoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto> _Tipo_ArtefactoRepository;
        #endregion

        #region Ctor
        public Tipo_ArtefactoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto> Tipo_ArtefactoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_ArtefactoRepository = Tipo_ArtefactoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto> SelAll(bool ConRelaciones)
        {
            return this._Tipo_ArtefactoRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_Artefacto.Tipo_Artefacto> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_ArtefactoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_ArtefactoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_ArtefactoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_ArtefactoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Artefacto.Tipo_ArtefactoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_ArtefactoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_ArtefactoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_ArtefactoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto entity, Spartane.Core.Domain.User.GlobalData Tipo_ArtefactoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_Artefacto.Tipo_Artefacto entity, Spartane.Core.Domain.User.GlobalData Tipo_ArtefactoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

