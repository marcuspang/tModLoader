using Terraria.ID;

namespace Terraria.DataStructures;

// Compatibility shim for older call sites still constructing the id-based projectile source directly.
public class EntitySource_ByProjectileSourceId : EntitySource_Misc
{
	public EntitySource_ByProjectileSourceId(int projectileSourceId)
		: base(ProjectileSourceID.ToContextString(projectileSourceId) ?? projectileSourceId.ToString())
	{
	}
}
