@ModelType QuizLomprayah2.PositionTable
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>PositionTable</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Position_Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Position_Title)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Position_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
