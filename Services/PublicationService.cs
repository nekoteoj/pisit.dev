using PisitDev.Models;

namespace PisitDev.Services;

public class PublicationService
{
    private readonly List<Publication> _publications = [
        new(
            Title: "Pep2Prob Benchmark: Predicting Fragment Ion Probability for MS-based Proteomics",
            Authors: ["Hao Xu", "Zhichao Wang", "Shengqi Sang", "Pisit Wajanasara", "Nuno Bandeira"],
            Year: 2025,
            Venue: "arXiv preprint [arXiv:2508.21076]",
            PaperUrl: "https://arxiv.org/abs/2508.21076",
            CodeUrl: "https://github.com/Bandeira-Lab/pep2prob-benchmark",
            IsConference: false
        ),
        new(
            Title: "A New Framework for Systematic Evaluation of Post-translational Modification Site Localization Approaches",
            Authors: ["Pisit Wajanasara", "Nuno Bandeira"],
            Year: 2024,
            Venue: "ASMS Conference on Mass Spectrometry and Allied Topics",
            IsConference: true
        )
    ];

    public IEnumerable<Publication> GetPublications() => _publications;
}
