﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Personas_a_Incluir;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Personas_a_Incluir
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Personas_a_IncluirService : IDetalle_de_Personas_a_IncluirService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir> _Detalle_de_Personas_a_IncluirRepository;
        #endregion

        #region Ctor
        public Detalle_de_Personas_a_IncluirService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir> Detalle_de_Personas_a_IncluirRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Personas_a_IncluirRepository = Detalle_de_Personas_a_IncluirRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Personas_a_IncluirRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Personas_a_IncluirRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Personas_a_IncluirRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Personas_a_IncluirRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Personas_a_IncluirRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_IncluirPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Personas_a_IncluirPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Personas_a_IncluirRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Personas_a_IncluirInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Personas_a_IncluirInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Personas_a_Incluir.Detalle_de_Personas_a_Incluir entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Personas_a_IncluirInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

