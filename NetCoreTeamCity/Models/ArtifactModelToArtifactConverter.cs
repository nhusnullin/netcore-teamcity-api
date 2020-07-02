namespace NetCoreTeamCity.Models
{
    internal static class ArtifactModelToArtifactConverter
    {
        public static Artifact Convert(this ArtifactModel model)
        {
            var artifact = new Artifact()
            {
                Name = model.Name,
                Size = model.Size,
                ModificationTime = model.ModificationTime,
                Metadata = new Href(model.Href),
                Content = new Href(model.Content?.Href)
            };
            return artifact;
        }
    }
}