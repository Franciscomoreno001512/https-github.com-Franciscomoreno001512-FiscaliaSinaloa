﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Marca_de_Equipo_Tactico;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Marca_de_Equipo_Tactico
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Marca_de_Equipo_TacticoService : IMarca_de_Equipo_TacticoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> _Marca_de_Equipo_TacticoRepository;
        #endregion

        #region Ctor
        public Marca_de_Equipo_TacticoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> Marca_de_Equipo_TacticoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Marca_de_Equipo_TacticoRepository = Marca_de_Equipo_TacticoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> SelAll(bool ConRelaciones)
        {
            return this._Marca_de_Equipo_TacticoRepository.Table.ToList();
        }

        public IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> SelAllComplete(bool ConRelaciones)
        {
            return this._Marca_de_Equipo_TacticoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Marca_de_Equipo_TacticoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Marca_de_Equipo_TacticoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Marca_de_Equipo_TacticoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_TacticoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Marca_de_Equipo_TacticoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Marca_de_Equipo_TacticoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Marca_de_Equipo_TacticoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico entity, Spartane.Core.Domain.User.GlobalData Marca_de_Equipo_TacticoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico entity, Spartane.Core.Domain.User.GlobalData Marca_de_Equipo_TacticoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

