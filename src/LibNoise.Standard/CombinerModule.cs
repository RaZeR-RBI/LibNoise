﻿// This file is part of libnoise-dotnet.
//
// libnoise-dotnet is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// libnoise-dotnet is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with libnoise-dotnet.  If not, see <http://www.gnu.org/licenses/>.
// 
// From the original Jason Bevins's Libnoise (http://libnoise.sourceforge.net)


namespace LibNoise
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class CombinerModule : IModule
    {
        #region Fields

        /// <summary>
        /// The left input module
        /// </summary>
        protected IModule _leftModule;

        /// <summary>
        /// The right input module
        /// </summary>
        protected IModule _rightModule;

        #endregion

        #region Accessors

        /// <summary>
        /// Gets or sets the left module
        /// </summary>
        public IModule LeftModule
        {
            get { return _leftModule; }
            set { _leftModule = value; }
        }

        /// <summary>
        /// Gets or sets the right module
        /// </summary>
        public IModule RightModule
        {
            get { return _rightModule; }
            set { _rightModule = value; }
        }

        #endregion

        #region Ctor/Dtor

        public CombinerModule()
        {
        }


        public CombinerModule(IModule left, IModule right)
        {
            _leftModule = left;
            _rightModule = right;
        }

        #endregion
    }
}
