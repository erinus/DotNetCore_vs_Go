<!DOCTYPE html>
<html>
<head>
</head>
<body>
    <p>Locales</p>
    <p>
        <table>
        {{ range $index, $entry := .Locales }}
            <tr>
                <td>{{ index $entry 0 }}</td>
                <td>{{ index $entry 1 }}</td>
                <td>{{ index $entry 2 }}</td>
                <td>{{ index $entry 3 }}</td>
                <td>{{ index $entry 4 }}</td>
                <td>{{ index $entry 5 }}</td>
                <td>{{ index $entry 6 }}</td>
            </tr>
        {{ end }}
        </table>
    </p>
</body>
</html>