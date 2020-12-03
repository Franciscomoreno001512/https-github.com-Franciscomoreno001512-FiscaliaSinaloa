using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Terreno_de_Inmuebles;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Terreno_de_Inmuebles
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Terreno_de_InmueblesService : ITerreno_de_InmueblesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> _Terreno_de_InmueblesRepository;
        #endregion

        #region Ctor
        public Terreno_de_InmueblesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> Terreno_de_InmueblesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Terreno_de_InmueblesRepository = Terreno_de_InmueblesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> SelAll(bool ConRelaciones)
        {
            return this._Terreno_de_InmueblesRepository.Table.ToList();
        }

        public IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> SelAllComplete(bool ConRelaciones)
        {
            return this._Terreno_de_InmueblesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Terreno_de_InmueblesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Terreno_de_InmueblesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Terreno_de_InmueblesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Terreno_de_InmueblesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Terreno_de_InmueblesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Terreno_de_InmueblesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles entity, Spartane.Core.Domain.User.GlobalData Terreno_de_InmueblesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles entity, Spartane.Core.Domain.User.GlobalData Terreno_de_InmueblesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

