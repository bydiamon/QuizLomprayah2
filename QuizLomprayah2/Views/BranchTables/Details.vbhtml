@ModelType QuizLomprayah2.BranchTable
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>BranchTable</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Branch_Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Branch_Title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PositionTable.Position_Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PositionTable.Position_Title)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Branch_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
