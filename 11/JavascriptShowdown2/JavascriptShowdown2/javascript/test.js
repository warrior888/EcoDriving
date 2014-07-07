function BartekJavascript(name) {
    alert(name);
}


function RenderHtml(tablica) {
    document.write('<table>');
    for (i = 0 ; i < tablica.length; i++) {
        var item = tablica[i];
        document.write("<tr><td>" + item.Id + "</td><td>" + item.Name + "</td></tr>");
    }
    document.write('</table>');
}