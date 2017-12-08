@ModelType QuizLomprayah2.EssayTest
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>EssayTest</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.EssayTest_Question)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EssayTest_Question)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EssayTest_Answer_User)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EssayTest_Answer_User)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EssayTest_Answer)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EssayTest_Answer)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EssayTest_ExamDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EssayTest_ExamDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book.subject_code)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
