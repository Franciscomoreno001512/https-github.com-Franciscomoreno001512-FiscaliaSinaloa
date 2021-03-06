﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Marca_de_Equipo_de_Comunicacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Marca_de_Equipo_de_ComunicacionService : IMarca_de_Equipo_de_ComunicacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion> _Marca_de_Equipo_de_ComunicacionRepository;
        #endregion

        #region Ctor
        public Marca_de_Equipo_de_ComunicacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion> Marca_de_Equipo_de_ComunicacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Marca_de_Equipo_de_ComunicacionRepository = Marca_de_Equipo_de_ComunicacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion> SelAll(bool ConRelaciones)
        {
            return this._Marca_de_Equipo_de_ComunicacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Marca_de_Equipo_de_ComunicacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Marca_de_Equipo_de_ComunicacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Marca_de_Equipo_de_ComunicacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Marca_de_Equipo_de_ComunicacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_ComunicacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Marca_de_Equipo_de_ComunicacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Marca_de_Equipo_de_ComunicacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Marca_de_Equipo_de_ComunicacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion entity, Spartane.Core.Domain.User.GlobalData Marca_de_Equipo_de_ComunicacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Marca_de_Equipo_de_Comunicacion.Marca_de_Equipo_de_Comunicacion entity, Spartane.Core.Domain.User.GlobalData Marca_de_Equipo_de_ComunicacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

