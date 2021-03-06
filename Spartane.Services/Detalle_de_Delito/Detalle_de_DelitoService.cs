﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Delito;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Delito
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_DelitoService : IDetalle_de_DelitoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito> _Detalle_de_DelitoRepository;
        #endregion

        #region Ctor
        public Detalle_de_DelitoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito> Detalle_de_DelitoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_DelitoRepository = Detalle_de_DelitoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_DelitoRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Delito.Detalle_de_Delito> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_DelitoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_DelitoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito entity, Spartane.Core.Domain.User.GlobalData Detalle_de_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Delito.Detalle_de_Delito entity, Spartane.Core.Domain.User.GlobalData Detalle_de_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

