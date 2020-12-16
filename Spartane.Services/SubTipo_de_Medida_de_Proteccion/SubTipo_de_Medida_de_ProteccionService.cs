﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.SubTipo_de_Medida_de_Proteccion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class SubTipo_de_Medida_de_ProteccionService : ISubTipo_de_Medida_de_ProteccionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion> _SubTipo_de_Medida_de_ProteccionRepository;
        #endregion

        #region Ctor
        public SubTipo_de_Medida_de_ProteccionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion> SubTipo_de_Medida_de_ProteccionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._SubTipo_de_Medida_de_ProteccionRepository = SubTipo_de_Medida_de_ProteccionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion> SelAll(bool ConRelaciones)
        {
            return this._SubTipo_de_Medida_de_ProteccionRepository.Table.ToList();
        }

        public IList<Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion> SelAllComplete(bool ConRelaciones)
        {
            return this._SubTipo_de_Medida_de_ProteccionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._SubTipo_de_Medida_de_ProteccionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._SubTipo_de_Medida_de_ProteccionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._SubTipo_de_Medida_de_ProteccionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_ProteccionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            SubTipo_de_Medida_de_ProteccionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._SubTipo_de_Medida_de_ProteccionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData SubTipo_de_Medida_de_ProteccionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion entity, Spartane.Core.Domain.User.GlobalData SubTipo_de_Medida_de_ProteccionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion.SubTipo_de_Medida_de_Proteccion entity, Spartane.Core.Domain.User.GlobalData SubTipo_de_Medida_de_ProteccionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

