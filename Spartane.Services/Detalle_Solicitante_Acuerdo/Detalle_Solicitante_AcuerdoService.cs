﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Solicitante_Acuerdo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Solicitante_Acuerdo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Solicitante_AcuerdoService : IDetalle_Solicitante_AcuerdoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo> _Detalle_Solicitante_AcuerdoRepository;
        #endregion

        #region Ctor
        public Detalle_Solicitante_AcuerdoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo> Detalle_Solicitante_AcuerdoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Solicitante_AcuerdoRepository = Detalle_Solicitante_AcuerdoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Solicitante_AcuerdoRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Solicitante_AcuerdoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Solicitante_AcuerdoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Solicitante_AcuerdoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Solicitante_AcuerdoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_AcuerdoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Solicitante_AcuerdoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Solicitante_AcuerdoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Solicitante_AcuerdoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo entity, Spartane.Core.Domain.User.GlobalData Detalle_Solicitante_AcuerdoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Solicitante_Acuerdo.Detalle_Solicitante_Acuerdo entity, Spartane.Core.Domain.User.GlobalData Detalle_Solicitante_AcuerdoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

