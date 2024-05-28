// SVG haritasını seçin
const svg = d3.select("#katman_1");

// Grubu seçin
const group = d3.select("#all-elements");

// Zoom ve pan işlevini oluşturun
const zoom = d3.zoom()
    .scaleExtent([1, 3]) // Zoom oranını sınırla
    .on("zoom", zoomed);

// Zoom işlevini SVG öğesine ekle
svg.call(zoom);

// Başlangıç durumunu saklamak için değişkenler
let initialTransform = d3.zoomIdentity;
// Zoom işlevi
function zoomed() {
    // D3 event nesnesini al
    const { transform } = d3.event;

    // Grubun konumunu güncelle
    group.attr("transform", transform);

    // Başlangıç durumunu güncelle
    initialTransform = transform;

    // Haritanın ekranın dışına çıkmamasını sağla
    const { x, y, k } = transform;
    const width = svg.attr("width");
    const height = svg.attr("height");
    const boundedX = Math.max(Math.min(x, 0), width - width * k);
    const boundedY = Math.max(Math.min(y, 0), height - height * k);
    svg.attr("transform", `translate(${boundedX},${boundedY}) scale(${k})`);
}

// Reset butonuna basıldığında zoom'u sıfırla
d3.select("#resetButton").on("click", function () {
    svg.transition()
        .duration(750)
        .call(zoom.transform, initialTransform);
});