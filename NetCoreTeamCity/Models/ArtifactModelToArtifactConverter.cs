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
                Href = model.Href,
                Content = new ArtifactContent(new Href(model.Content.Href))
            };
            return artifact;
        }
    }
}