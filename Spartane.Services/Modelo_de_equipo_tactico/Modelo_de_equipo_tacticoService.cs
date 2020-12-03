using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Modelo_de_equipo_tactico;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Modelo_de_equipo_tactico
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Modelo_de_equipo_tacticoService : IModelo_de_equipo_tacticoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> _Modelo_de_equipo_tacticoRepository;
        #endregion

        #region Ctor
        public Modelo_de_equipo_tacticoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> Modelo_de_equipo_tacticoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Modelo_de_equipo_tacticoRepository = Modelo_de_equipo_tacticoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> SelAll(bool ConRelaciones)
        {
            return this._Modelo_de_equipo_tacticoRepository.Table.ToList();
        }

        public IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> SelAllComplete(bool ConRelaciones)
        {
            return this._Modelo_de_equipo_tacticoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modelo_de_equipo_tacticoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Modelo_de_equipo_tacticoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modelo_de_equipo_tacticoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Modelo_de_equipo_tacticoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Modelo_de_equipo_tacticoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Modelo_de_equipo_tacticoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico entity, Spartane.Core.Domain.User.GlobalData Modelo_de_equipo_tacticoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico entity, Spartane.Core.Domain.User.GlobalData Modelo_de_equipo_tacticoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

