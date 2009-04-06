using System;
using System.Collections.Generic;
using System.Text;
using VapeTeam.Psimulex.Graphics;
using VapeTeam.Psimulex.Core.Types;

namespace VapeTeam.Psimulex.Graphics.Factories
{
	/// <summary>
	/// Ez a gyár fogja létrehozni a grafikus elemeket, típus alapján.
	/// </summary>
	class GraphicsElementFactory
	{
		public static GraphicsElement Produce(BaseType value)
		{
			if (value == null)
				return new ScalarGraphics(new VapeTeam.Psimulex.Core.Types.String("NULL"));
			switch (value.Type.TypeEnum)
			{
                case TypeEnum.Integer:
 					return new ScalarGraphics(value);
                case TypeEnum.Array:
					return new ArrayGraphics(value.ToArray());
                case TypeEnum.Tree:
					return new TreeGraphics(value.ToTree());
                case TypeEnum.BinaryTree:
					return new TreeGraphics(value.ToBinaryTree());

				default:
					if (TypeHierarchy.IsContainer(value))
					{
						return new ArrayGraphics(value as AbstractCollection);
					}
					return new ScalarGraphics(value);
			}
		}
	}
}
